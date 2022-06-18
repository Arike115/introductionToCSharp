using introductionToCSharp.Student;
using System;

namespace introductionToCSharp
{
    class Program
   {
       static void Main()
        {
            StudentClass cust = new StudentClass();
            cust.Name = "Brad pitt";
            cust.Gender = Gender.unknown;
            cust.Age = 20;
            cust.PaymentType = PaymentType.POS;
            cust.fulldetails();

            StudentClass custs = new StudentClass();
            custs.Name = "Jude Mratins";
            custs.Gender = Gender.Male;
            custs.Age = 30;
            custs.PaymentType = PaymentType.Transfer;
            custs.fulldetails();

            StudentClass custo = new StudentClass();
            custo.Name = "Naomi cambello";
            custo.Gender = Gender.Female;
            custo.Age = 45;
            custo.PaymentType = PaymentType.POS;
            custo.fulldetails();

            StudentClass.StudentClassdetails classdetails = new StudentClass.StudentClassdetails();
            classdetails.fulldetails();
        }


    }

   



}
