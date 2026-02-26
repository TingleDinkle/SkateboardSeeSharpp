using System.Data;
using System.Data.SqlClient;

namespace SkateboardSeeSharp.DAL
{
    public class ProductDAL
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"SELECT p.Product_ID, p.Product_Name, p.Selling_Price, p.Inventory_Quantity,
                                 p.Description, p.Product_Image, p.Category_ID, c.Category_Name
                                 FROM Product p
                                 LEFT JOIN Category c ON p.Category_ID = c.Category_ID
                                 ORDER BY p.Product_Name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable GetByCategory(string categoryId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"SELECT p.Product_ID, p.Product_Name, p.Selling_Price, p.Inventory_Quantity,
                                 p.Description, p.Category_ID, c.Category_Name
                                 FROM Product p
                                 LEFT JOIN Category c ON p.Category_ID = c.Category_ID
                                 WHERE p.Category_ID = @CatID
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
                string query = @"SELECT p.Product_ID, p.Product_Name, p.Selling_Price, p.Inventory_Quantity,
                                 p.Description, p.Category_ID, c.Category_Name
                                 FROM Product p
                                 LEFT JOIN Category c ON p.Category_ID = c.Category_ID
                                 WHERE (p.Product_Name LIKE @Search OR p.Product_ID LIKE @Search)";
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

        public bool Insert(string productId, string productName, decimal sellingPrice, int inventoryQty,
                           string description, string productImage, string categoryId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"INSERT INTO Product (Product_ID, Product_Name, Selling_Price, Inventory_Quantity, Description, Product_Image, Category_ID)
                                 VALUES (@ProdID, @ProdName, @Price, @Qty, @Desc, @Image, @CatID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProdID", productId);
                cmd.Parameters.AddWithValue("@ProdName", productName);
                cmd.Parameters.AddWithValue("@Price", sellingPrice);
                cmd.Parameters.AddWithValue("@Qty", inventoryQty);
                cmd.Parameters.AddWithValue("@Desc", description ?? (object)System.DBNull.Value);
                cmd.Parameters.AddWithValue("@Image", productImage ?? (object)System.DBNull.Value);
                cmd.Parameters.AddWithValue("@CatID", categoryId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(string productId, string productName, decimal sellingPrice, int inventoryQty,
                           string description, string productImage, string categoryId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"UPDATE Product SET Product_Name=@ProdName, Selling_Price=@Price,
                                 Inventory_Quantity=@Qty, Description=@Desc, Product_Image=@Image, Category_ID=@CatID
                                 WHERE Product_ID=@ProdID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProdID", productId);
                cmd.Parameters.AddWithValue("@ProdName", productName);
                cmd.Parameters.AddWithValue("@Price", sellingPrice);
                cmd.Parameters.AddWithValue("@Qty", inventoryQty);
                cmd.Parameters.AddWithValue("@Desc", description ?? (object)System.DBNull.Value);
                cmd.Parameters.AddWithValue("@Image", productImage ?? (object)System.DBNull.Value);
                cmd.Parameters.AddWithValue("@CatID", categoryId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string productId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Product WHERE Product_ID = @ProdID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProdID", productId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateStock(string productId, int quantityChange)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "UPDATE Product SET Inventory_Quantity = Inventory_Quantity + @Change WHERE Product_ID = @ProdID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProdID", productId);
                cmd.Parameters.AddWithValue("@Change", quantityChange);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public string GetNextProductId()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Product";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return "PROD" + (count + 1).ToString("D4");
            }
        }
    }
}
