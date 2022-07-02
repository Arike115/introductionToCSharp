using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introductionToCSharp.Student
{
    
    public  class Mydetails
    {
      public int DurationHour { get; set; }
      public DateTime CreatedOnTime { get; set; }

       public Mydetails(int durationhour)
        {
            DurationHour = durationhour;
            CreatedOnTime = DateTime.Now;
        }

        //operator overloading
        public static Mydetails operator *(Mydetails a, Mydetails b)
        {
            return new Mydetails(a.DurationHour * b.DurationHour);
        }
    }
}
