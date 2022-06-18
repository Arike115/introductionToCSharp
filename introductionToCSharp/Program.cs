using introductionToCSharp.Student;
using System;

namespace introductionToCSharp
{
     class Program
   {
        studentdetails cuts = new studentdetails();

        static void Main()
        {
            int j = 100;
            int i = 200;

            decimal result = j + i;

            var total = Mydetails<int>.Equalsdetails(5, 5);
            var amount = Mydetails<string>.Equalsnumber("ab", "ab");


            if(total)
            {
                Console.WriteLine("details are equal");
            }
            else
            {
                Console.WriteLine("details not equal");
            }

            
        }


    }

   



}
