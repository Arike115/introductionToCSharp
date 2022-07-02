using introductionToCSharp.Student;
using System;
using System.Collections.Generic;
using System.IO;

namespace introductionToCSharp
{
    
    
    class Program
    {
       
        //Dynamic Binding
        static void Main()
        {

            Mydetails ticket = new Mydetails(2);
            Mydetails ticket2 = new Mydetails(30);

            Mydetails allticket = ticket * ticket2;

            Console.WriteLine("the total duration in hours is :{0}, {1}", allticket.DurationHour, ticket.CreatedOnTime);





        }

        


    }

      

 }

   




