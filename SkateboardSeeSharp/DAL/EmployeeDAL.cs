using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SkateboardSeeSharp.Models;

namespace SkateboardSeeSharp.DAL
{
    public class EmployeeDAL
    {
        public Employee GetByUsername(string username)
        {
            Employee employee = null;
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT Employee_ID, Employee_Name, Position, Authority, Username, Password, Phone_Number, Email FROM Employee WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        employee = new Employee
                        {
                            EmployeeID = reader["Employee_ID"].ToString(),
                            EmployeeName = reader["Employee_Name"].ToString(),
                            Position = reader["Position"].ToString(),
                            Authority = reader["Authority"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString().Trim(),
                            PhoneNumber = reader["Phone_Number"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                    }
                }
            }
            return employee;
        }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT Employee_ID, Employee_Name, Position, Authority, Username, Phone_Number, Email FROM Employee";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public bool Insert(Employee emp)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"INSERT INTO Employee (Employee_ID, Employee_Name, Position, Authority, Username, Password, Phone_Number, Email)
                                 VALUES (@EmpID, @EmpName, @Position, @Authority, @Username, @Password, @Phone, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpID", emp.EmployeeID);
                cmd.Parameters.AddWithValue("@EmpName", emp.EmployeeName);
                cmd.Parameters.AddWithValue("@Position", emp.Position);
                cmd.Parameters.AddWithValue("@Authority", emp.Authority);
                cmd.Parameters.AddWithValue("@Username", emp.Username);
                cmd.Parameters.AddWithValue("@Password", PasswordHelper.HashPassword(emp.Password));
                cmd.Parameters.AddWithValue("@Phone", emp.PhoneNumber ?? (object)System.DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", emp.Email ?? (object)System.DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(Employee emp, bool updatePassword)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query;
                if (updatePassword)
                {
                    query = @"UPDATE Employee SET Employee_Name=@EmpName, Position=@Position, Authority=@Authority,
                              Username=@Username, Password=@Password, Phone_Number=@Phone, Email=@Email
                              WHERE Employee_ID=@EmpID";
                }
                else
                {
                    query = @"UPDATE Employee SET Employee_Name=@EmpName, Position=@Position, Authority=@Authority,
                              Username=@Username, Phone_Number=@Phone, Email=@Email
                              WHERE Employee_ID=@EmpID";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpID", emp.EmployeeID);
                cmd.Parameters.AddWithValue("@EmpName", emp.EmployeeName);
                cmd.Parameters.AddWithValue("@Position", emp.Position);
                cmd.Parameters.AddWithValue("@Authority", emp.Authority);
                cmd.Parameters.AddWithValue("@Username", emp.Username);
                cmd.Parameters.AddWithValue("@Phone", emp.PhoneNumber ?? (object)System.DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", emp.Email ?? (object)System.DBNull.Value);

                if (updatePassword)
                {
                    cmd.Parameters.AddWithValue("@Password", PasswordHelper.HashPassword(emp.Password));
                }

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string employeeId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Employee WHERE Employee_ID = @EmpID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpID", employeeId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UsernameExists(string username, string excludeEmployeeId = null)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Employee WHERE Username = @Username";
                if (excludeEmployeeId != null)
                {
                    query += " AND Employee_ID <> @ExcludeID";
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                if (excludeEmployeeId != null)
                {
                    cmd.Parameters.AddWithValue("@ExcludeID", excludeEmployeeId);
                }
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public string GetNextEmployeeId()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Employee";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return "EMP" + (count + 1).ToString("D4");
            }
        }
    }
}
