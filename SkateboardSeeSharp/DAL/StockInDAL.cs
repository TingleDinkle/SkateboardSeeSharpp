using System;
using System.Data;
using System.Data.SqlClient;

namespace SkateboardSeeSharp.DAL
{
    public class StockInDAL
    {
        public DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"SELECT p.Product_ID, p.Product_Name, c.Category_Name, p.Selling_Price,
                                 p.Inventory_Quantity, p.Description, p.Category_ID
                                 FROM Product p
                                 LEFT JOIN Category c ON p.Category_ID = c.Category_ID
                                 ORDER BY p.Product_Name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public string GetNextImportId()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string prefix = "IMP-" + DateTime.Now.ToString("yyyyMMdd") + "-";
                string query = "SELECT COUNT(*) FROM ImportOrder WHERE Import_Order_ID LIKE @Prefix";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Prefix", prefix + "%");
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return prefix + (count + 1).ToString("D4");
            }
        }

        public bool CreateImportOrder(string importOrderId, string employeeId, decimal totalAmount,
                                       string notes, DataTable importLines)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Insert ImportOrder
                    string orderQuery = @"INSERT INTO ImportOrder (Import_Order_ID, Import_Date, Employee_ID, Total_Amount, Notes)
                                          VALUES (@ImportID, @ImportDate, @EmployeeID, @Total, @Notes)";
                    SqlCommand orderCmd = new SqlCommand(orderQuery, conn, transaction);
                    orderCmd.Parameters.AddWithValue("@ImportID", importOrderId);
                    orderCmd.Parameters.AddWithValue("@ImportDate", DateTime.Now);
                    orderCmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                    orderCmd.Parameters.AddWithValue("@Total", totalAmount);
                    orderCmd.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);
                    orderCmd.ExecuteNonQuery();

                    // Insert ImportDetail rows and update stock
                    foreach (DataRow row in importLines.Rows)
                    {
                        string detailQuery = @"INSERT INTO ImportDetail (Import_Order_ID, Product_ID, Import_Quantity, Import_Price)
                                               VALUES (@ImportID, @ProductID, @Qty, @Price)";
                        SqlCommand detailCmd = new SqlCommand(detailQuery, conn, transaction);
                        detailCmd.Parameters.AddWithValue("@ImportID", importOrderId);
                        detailCmd.Parameters.AddWithValue("@ProductID", row["Product_ID"].ToString());
                        detailCmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(row["Import_Quantity"]));
                        detailCmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(row["Import_Price"]));
                        detailCmd.ExecuteNonQuery();

                        // Increment stock
                        string stockQuery = "UPDATE Product SET Inventory_Quantity = Inventory_Quantity + @Qty WHERE Product_ID = @ProdID";
                        SqlCommand stockCmd = new SqlCommand(stockQuery, conn, transaction);
                        stockCmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(row["Import_Quantity"]));
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
    }
}
