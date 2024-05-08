using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace AuthenticationAccess.EncryptSecurity
{
    public static class EncryptPassword
    {
        public static (string Salt, string HashPassword) HashPassword(string password)
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] salt = new byte[16]; // 128-bit salt
                rng.GetBytes(salt);
                int iterations = 100000;

                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
                {
                    byte[] hash = pbkdf2.GetBytes(32); // 256-bit hash
                    string base64Salt = Convert.ToBase64String(salt);
                    string base64Hash = Convert.ToBase64String(hash);
                    return (base64Salt, base64Hash);
                }
            }
        }

        public static bool VerifyPassword(string password, string storedBase64Salt, string storedBase64Hash)
        {
            byte[] storedSalt = Convert.FromBase64String(storedBase64Salt);
            byte[] storedHash = Convert.FromBase64String(storedBase64Hash);

            int iterations = 100000;

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, storedSalt, iterations))
            {
                byte[] hash = pbkdf2.GetBytes(32);
                for (int i = 0; i < hash.Length; i++)
                {
                    if (storedHash[i] != hash[i])
                    {
                        return false;
                    }
                }
                Logger.Logger.Log("Verification process completed.", Logger.Logger.LogType.Message);
                return true;

            }
        }
    }
}
