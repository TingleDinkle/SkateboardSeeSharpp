using System.Data;
using System.Data.SqlClient;

namespace SkateboardSeeSharp.DAL
{
    public class CategoryDAL
    {
        public DataTable GetAll()
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

        public bool Insert(string categoryId, string categoryName)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "INSERT INTO Category (Category_ID, Category_Name) VALUES (@CatID, @CatName)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CatID", categoryId);
                cmd.Parameters.AddWithValue("@CatName", categoryName);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(string categoryId, string categoryName)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "UPDATE Category SET Category_Name = @CatName WHERE Category_ID = @CatID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CatID", categoryId);
                cmd.Parameters.AddWithValue("@CatName", categoryName);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string categoryId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Category WHERE Category_ID = @CatID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CatID", categoryId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public string GetNextCategoryId()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Category";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return "CAT" + (count + 1).ToString("D4");
            }
        }
    }
}
