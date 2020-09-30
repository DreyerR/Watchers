using System.Text;
using System.Security.Cryptography;

namespace Watchers.Common
{
    class SHA
    {
        public static string ToSHA256(string text)
        {
            SHA256Managed crypt = new SHA256Managed();
            StringBuilder hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(text));

            foreach (byte aByte in crypto)
            {
                hash.Append(aByte.ToString("x2"));
            }

            return hash.ToString();
        }
    }
}
