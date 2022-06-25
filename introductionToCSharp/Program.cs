using introductionToCSharp.Student;
using System;
using System.Collections.Generic;
using System.IO;

namespace introductionToCSharp
{
    public delegate bool Result(Employee message);
    class Program
    {
        static void Main()
        {

            //try statements and exceptions
            //try
            //{
            //    string content = File.ReadAllText(@"D:\Document\academy assignme.txt");
            //    Console.WriteLine(content);
            //}
            //catch (DirectoryNotFoundException ex)
            //{
            //    Console.WriteLine("oops Problem found at the directory");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("oops Problem found");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("oops Problem found");
            //    Console.WriteLine(ex.Message);
            //}

            //Console.ReadLine();

            Console.WriteLine("please enter salary figure");

            int salaryamount = int.Parse(Console.ReadLine());


            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee() { Id = 1, Name = "john", Salary = 5000, Experience = 2 });
            emp.Add(new Employee() { Id = 2, Name = "Ben", Salary = 10000, Experience = 1 });
            emp.Add(new Employee() { Id = 3, Name = "joy", Salary = 15000, Experience = 5 });
            emp.Add(new Employee() { Id = 4, Name = "Mary", Salary = 25000, Experience = 5 });
            emp.Add(new Employee() { Id = 5, Name = "Sade", Salary = 45000, Experience = 6 });

           //anonymous method
           Employee newemployee = emp.Find(
               delegate(Employee em)
               {
                   return em.Salary == salaryamount;
               });
            Console.WriteLine("Id : {0}, Name:{1}, Experience : {2}", newemployee.Id, newemployee.Name, newemployee.Experience);

        }

      
    }

      

 }

   




