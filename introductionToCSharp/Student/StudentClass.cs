using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introductionToCSharp.Student
{
    public class Mydetails<r>
    {
        public static bool Equalsnumber(r number, r number2)
        {
            return number.Equals(number2);
        }

        public static bool Equalsdetails(r firstnumber, r secondnumber)
        {
            return firstnumber.Equals(secondnumber);
        }
    }
}
