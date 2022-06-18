using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introductionToCSharp.Student
{
    public class StudentClass
    {

        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public PaymentType PaymentType { get; set; }

        public void  fulldetails()
        {
            Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}, Payment:{3}", Name, Gender, Age, PaymentType);
        }

        public class StudentClassdetails
        {

            public void fulldetails()
            {
                Console.WriteLine("your are welcome to the nested class");
            }
        }
    }

    public enum Gender
    {
        Male = 1,
        Female = 2,
        unknown = 3
    }

    public enum PaymentType
    { 
        Cash,
        POS,
        Transfer
    }

}
