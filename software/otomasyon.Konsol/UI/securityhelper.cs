using System.Security.Cryptography;
using System.Text;



namespace Otomasyon.UI
{

    public static class SecurityHelper
    {
        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                using (var sha256 = SHA256.Create())
                {
                    var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                    return Convert.ToHexString(bytes).ToLowerInvariant();
                }



            }
        }
    }



}