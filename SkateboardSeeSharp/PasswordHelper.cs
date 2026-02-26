using System.Security.Cryptography;
using System.Text;

namespace SkateboardSeeSharp
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public static bool VerifyPassword(string plainPassword, string hashedPassword)
        {
            string hash = HashPassword(plainPassword);
            return hash == hashedPassword;
        }
    }
}
