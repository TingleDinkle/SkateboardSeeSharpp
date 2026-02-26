using System.Configuration;
using System.Data.SqlClient;

namespace SkateboardSeeSharp
{
    public static class DBConnection
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["SkateboardShopDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
