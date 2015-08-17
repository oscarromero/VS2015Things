using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string inputString) 
        {
            if (inputString.Length > 0) {
                char[] chars = inputString.ToCharArray();
                chars[0] = char.IsUpper(chars[0]) ? char.ToLower(chars[0]) : char.ToUpper(chars[0]);
                return new string(chars);
            }

            return inputString;
        }
    }
}
