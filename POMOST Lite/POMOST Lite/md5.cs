using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace POMOST_Lite
{
    public class md5
    {
        public string SzyfrujMD5(string input) //szfrowanie MD5
        {
            MD5 md5 = MD5.Create();
            byte[] inputbytes = Encoding.ASCII.GetBytes(input);
            byte[] hasbytes = md5.ComputeHash(inputbytes);
            StringBuilder strBuild = new StringBuilder();
            for (int i = 0; i < hasbytes.Length; i++)
            {
                strBuild.Append(hasbytes[i].ToString("X2"));
            }
            return strBuild.ToString();
        }
    }
}
