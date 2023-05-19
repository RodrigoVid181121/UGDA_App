using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios.Encrypt
{
    public class ClsEncrypt
    {
        public static string GETSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] bytes = null;

            StringBuilder strb = new StringBuilder();

            bytes = sha256.ComputeHash(encoding.GetBytes(str));

            for (int i = 0; i < bytes.Length; i++)
            {
                strb.AppendFormat("{0:x2}", bytes[i]);
            }

            return strb.ToString();
        }
    }
}
