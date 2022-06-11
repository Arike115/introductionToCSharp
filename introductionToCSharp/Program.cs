using System;

namespace introductionToCSharp
{
    class Program
   {
       static void Main()
        {
            //loops
            int[] numbers = new int[5];
            numbers[0] = 250;
            numbers[1] = 235;
            numbers[2] = 10;
            numbers[3] = 78;
            numbers[4] = 76;

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
             Console.WriteLine("***********");

            for (int j = 0; j < numbers.Length; j = j+2)
            {
                Console.WriteLine(numbers[j]);
            }
            Console.WriteLine("***********");
            int i = 0;

            while(i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }


        }


    }

   



}
