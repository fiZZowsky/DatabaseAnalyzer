using System;
using System.Security.Cryptography;
using System.Text;

namespace DatabaseAnalyzer.Helpers
{
    public static class EncryptionHelper
    {
        private static readonly byte[] s_entropy = { 0x1, 0x5, 0x9, 0xC, 0x2, 0x6, 0xA, 0xD };

        public static string EncryptString(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
                return string.Empty;

            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            
            byte[] cipherBytes = ProtectedData.Protect(
                plainTextBytes,
                s_entropy,
                DataProtectionScope.CurrentUser);

            return Convert.ToBase64String(cipherBytes);
        }

        public static string DecryptString(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText))
                return string.Empty;

            try
            {
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                
                byte[] plainTextBytes = ProtectedData.Unprotect(
                    cipherBytes,
                    s_entropy,
                    DataProtectionScope.CurrentUser);

                return Encoding.UTF8.GetString(plainTextBytes);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error decrypting password: " + ex.Message);
                return string.Empty;
            }
        }
    }
}