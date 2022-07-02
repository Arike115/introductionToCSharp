using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introductionToCSharp.Student
{
   public static class Electronics
    {
        public static string ChangeFirstLetterCase(this string inputstring)
        {
            if(inputstring.Length > 0)
             {
                char[] charArray = inputstring.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }

            return inputstring;
        }
    }
}
