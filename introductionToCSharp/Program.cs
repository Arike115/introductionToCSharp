using System;

namespace introductionToCSharp
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("input your FullName");
            //string fullname = Console.ReadLine();
            //Console.WriteLine("Wellcome our dear customer {0}", fullname);

            //built in types
            string names = "jsajhrjwjhr";
            int numbers = 570;
            bool words = true;
            decimal number = 74;
            double num = 45.78;
            long allnum = 5757575757575757570;
            float allnumbers = 65385F;
            //Console.WriteLine(int.MaxValue);

            //operators in c#
            //Arithmetic Operators

            int newnumber = 12;
            int newnum = 15;

            int result = newnumber + newnum;
            int newresult = newnum - newnumber;
            int mult = newnum;
            //Console.WriteLine(newresult);
            //Console.WriteLine(mult);

            //Relational Operators
            // ==, !=, >, <, >=,<=
            //Console.WriteLine("Please enter a number");
            //string fullname = Console.ReadLine();
            //int newnumbers = 17;

            //if (newnumbers >= 17)
            //{
            //    Console.WriteLine("the number is correct");

            //}
            //else
            //{
            //    Console.WriteLine("incorrect pin");
            //}

            //Logical Operators
            // && => and , || => or, !=> not


            string fruits = "Apple";
            string word = "pen";

            if ( fruits != "pen" || word =="chalk")
            {
                Console.WriteLine("the words are correct");
            }
            else
            {
                Console.WriteLine("the words are incorrect");
            }

            ////null coalescing operator
            ///??

            int? r = null;
            Console.WriteLine("please enter your name");
            string myname = null;

            string name = myname ?? "boluwatife";
                
            Console.WriteLine(name);


        }

    }

    
}
