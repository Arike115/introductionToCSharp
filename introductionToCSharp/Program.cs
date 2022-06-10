using System;

namespace introductionToCSharp
{
    class Program
   {
       static void Main()
        {


            //Statements
            //conditional-statmenet
            //switch case
            int totalamount = 100;
            start:
            Console.WriteLine("Please select your menu. 1... rice, 2....beans, 3 ...chicken");
            int result = int.Parse(Console.ReadLine());

            switch (result)
            {
                case 1:
                case 2:
                case 3:
                    break;
                default:
                    Console.WriteLine("your choice {0} is invalid", result);
                    break;

            }

            decide:
            Console.WriteLine(" Do you want to buy another item .... YES OR NO");
            string userdecision = Console.ReadLine();

            switch (userdecision.ToUpper())
            {
                case "YES":
                    goto start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("your choice {0} is invalid. please try again...",userdecision);
                    goto decide;


            }

            Console.WriteLine("thank you for your patronage");
            Console.WriteLine("Bill Amount - {0}", totalamount + result);






        }


    }

   



}
