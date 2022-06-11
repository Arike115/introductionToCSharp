using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introductionToCSharp
{
    public class customer
    {
        string _firstname;//field
        string _lastname;
        int _phonenumber;
        decimal _quantity;


        //constructor
        public customer(string Firstname, string Lastname, decimal total)
        {
            _firstname = Firstname;
            _lastname = Lastname;
            _quantity = total;
        }

        //method
        public void Fullname()
        {
            Console.WriteLine("full name = {0}", _firstname + " " + _lastname);
        }
        //method
        public void Justname()
        {
            Console.WriteLine("justname = {0}", _lastname);
        }

    }
}
