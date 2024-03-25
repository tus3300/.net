using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class Library
    {
        public static string EndCodeMD5(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
     
        public static string convertVND(string money)
        {
            var format = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            string value = String.Format(format, "{0:N0}", Convert.ToDouble(money));
            return value;
        }
    
    }
}
