using System;

namespace introductionToCSharp
{
    ////inheritance

    //public class student
    //{
    //    string _name;
    //    int _age;
    //}

    //interface 

    public interface IStudent
    {
        void ALLdetails();
            void GetMethod();

    }

    public class studentdetails : IStudent
    {
        public void ALLdetails()
        {
            Console.WriteLine("welcome to csharp class");
        }

        public void GetMethod()
        {
            throw new NotImplementedException();
        }
    }
    public struct customer :IStudent
    {
        string _name;

        public void ALLdetails()
        {
            throw new NotImplementedException();
        }

        public void fulldetails()
        {
            Console.WriteLine("hello world");
        }

        public void GetMethod()
        {
            throw new NotImplementedException();
        }
    }



}
