using System.Data;
using System.Data.SqlClient;

namespace SkateboardSeeSharp.DAL
{
    public class CustomerDAL
    {
        public DataTable GetAll()
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

        public DataTable Search(string searchText)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"SELECT Customer_ID, Customer_Name, Phone_Number, Address, Email
                                 FROM Customer
                                 WHERE Customer_Name LIKE @Search
                                    OR Phone_Number LIKE @Search
                                    OR Email LIKE @Search
                                    OR Customer_ID LIKE @Search
                                 ORDER BY Customer_Name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + searchText + "%");
                adapter.Fill(dt);
            }
            return dt;
        }

        public bool Insert(string customerId, string name, string phone, string address, string email)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"INSERT INTO Customer (Customer_ID, Customer_Name, Phone_Number, Address, Email)
                                 VALUES (@ID, @Name, @Phone, @Address, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", customerId);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Phone", (object)phone ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)address ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", (object)email ?? System.DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(string customerId, string name, string phone, string address, string email)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"UPDATE Customer
                                 SET Customer_Name=@Name, Phone_Number=@Phone, Address=@Address, Email=@Email
                                 WHERE Customer_ID=@ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", customerId);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Phone", string.IsNullOrWhiteSpace(phone) ? System.DBNull.Value : (object)phone);
                cmd.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(address) ? System.DBNull.Value : (object)address);
                cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(email) ? System.DBNull.Value : (object)email);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string customerId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Customer WHERE Customer_ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", customerId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public string GetNextCustomerId()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Customer";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return "CUST" + (count + 1).ToString("D4");
            }
        }
    }
}
