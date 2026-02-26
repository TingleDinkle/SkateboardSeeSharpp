using System;
using System.Data;
using System.Data.SqlClient;

namespace SkateboardSeeSharp.DAL
{
    public class OrderDAL
    {
        public DataTable GetProducts()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"SELECT p.Product_ID, p.Product_Name, c.Category_Name, p.Selling_Price, p.Inventory_Quantity
                                 FROM Product p
                                 LEFT JOIN Category c ON p.Category_ID = c.Category_ID
                                 WHERE p.Inventory_Quantity > 0
                                 ORDER BY p.Product_Name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable GetProductsByCategory(string categoryId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"SELECT p.Product_ID, p.Product_Name, c.Category_Name, p.Selling_Price, p.Inventory_Quantity
                                 FROM Product p
                                 LEFT JOIN Category c ON p.Category_ID = c.Category_ID
                                 WHERE p.Inventory_Quantity > 0 AND p.Category_ID = @CatID
                                 ORDER BY p.Product_Name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@CatID", categoryId);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable SearchProducts(string searchText, string categoryId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"SELECT p.Product_ID, p.Product_Name, c.Category_Name, p.Selling_Price, p.Inventory_Quantity
                                 FROM Product p
                                 LEFT JOIN Category c ON p.Category_ID = c.Category_ID
                                 WHERE p.Inventory_Quantity > 0
                                 AND (p.Product_Name LIKE @Search OR p.Product_ID LIKE @Search)";
                if (!string.IsNullOrEmpty(categoryId))
                {
                    query += " AND p.Category_ID = @CatID";
                }
                query += " ORDER BY p.Product_Name";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + searchText + "%");
                if (!string.IsNullOrEmpty(categoryId))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@CatID", categoryId);
                }
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable GetCustomers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT Customer_ID, Customer_Name, Phone_Number, Address, Email FROM Customer ORDER BY Customer_Name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public string GetNextOrderId()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string prefix = "SO-" + DateTime.Now.ToString("yyyyMMdd") + "-";
                string query = "SELECT COUNT(*) FROM SalesOrder WHERE Sales_Order_ID LIKE @Prefix";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Prefix", prefix + "%");
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return prefix + (count + 1).ToString("D4");
            }
        }

        public bool CreateOrder(string orderId, string customerId, string employeeId,
                                decimal totalAmount, decimal discountAmount, string notes,
                                DataTable orderLines)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Insert SalesOrder
                    string orderQuery = @"INSERT INTO SalesOrder (Sales_Order_ID, Sales_Date, Customer_Code, Employee_Code, Total_Amount, Discount_Amount, Notes)
                                          VALUES (@OrderID, @SalesDate, @CustomerID, @EmployeeID, @Total, @Discount, @Notes)";
                    SqlCommand orderCmd = new SqlCommand(orderQuery, conn, transaction);
                    orderCmd.Parameters.AddWithValue("@OrderID", orderId);
                    orderCmd.Parameters.AddWithValue("@SalesDate", DateTime.Now);
                    orderCmd.Parameters.AddWithValue("@CustomerID", customerId ?? (object)DBNull.Value);
                    orderCmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                    orderCmd.Parameters.AddWithValue("@Total", totalAmount);
                    orderCmd.Parameters.AddWithValue("@Discount", discountAmount);
                    orderCmd.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);
                    orderCmd.ExecuteNonQuery();

                    // Insert SalesDetail rows and update stock
                    foreach (DataRow row in orderLines.Rows)
                    {
                        string detailQuery = @"INSERT INTO SalesDetail (Sales_Order_ID, Product_Code, Sales_Quantity, Unit_Price, Subtotal)
                                               VALUES (@OrderID, @ProductID, @Qty, @Price, @Subtotal)";
                        SqlCommand detailCmd = new SqlCommand(detailQuery, conn, transaction);
                        detailCmd.Parameters.AddWithValue("@OrderID", orderId);
                        detailCmd.Parameters.AddWithValue("@ProductID", row["Product_ID"].ToString());
                        detailCmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(row["Quantity"]));
                        detailCmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(row["Unit_Price"]));
                        detailCmd.Parameters.AddWithValue("@Subtotal", Convert.ToDecimal(row["Subtotal"]));
                        detailCmd.ExecuteNonQuery();

                        // Decrement stock
                        string stockQuery = "UPDATE Product SET Inventory_Quantity = Inventory_Quantity - @Qty WHERE Product_ID = @ProdID";
                        SqlCommand stockCmd = new SqlCommand(stockQuery, conn, transaction);
                        stockCmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(row["Quantity"]));
                        stockCmd.Parameters.AddWithValue("@ProdID", row["Product_ID"].ToString());
                        stockCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public DataTable GetCategories()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT Category_ID, Category_Name FROM Category ORDER BY Category_Name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable GetProductsByFilter(string categoryId, string searchText)
        {
            if (!string.IsNullOrEmpty(searchText))
            {
                return SearchProducts(searchText, categoryId);
            }
            else if (!string.IsNullOrEmpty(categoryId))
            {
                return GetProductsByCategory(categoryId);
            }
            else
            {
                return GetProducts();
            }
        }
    }
}
