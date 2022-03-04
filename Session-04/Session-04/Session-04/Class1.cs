using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class1
    {
        
        public static string ReverseString(string myStr)
        {
            char[] myArr = myStr.ToCharArray();
            string reverse = string.Empty;
            for (int i = myArr.Length - 1; i >= 0; i--)
            {
                reverse += myArr[i];
            }
            return reverse;
        }
    }
}
