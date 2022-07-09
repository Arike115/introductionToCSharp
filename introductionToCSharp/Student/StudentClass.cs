using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introductionToCSharp.Student
{
    
    public  class Mydetails
    {
      public string Name { get; set; }
      public int Age { get; set; }

       public Mydetails(string name,int age)
        {
            Name = name;
            Age = age;
        }


    }

  public class Details : IEnumerable
    {
        public Mydetails[] player = new Mydetails[4];

        public Details()
        {
            player[0] = new Mydetails("joy", 23);
            player[1] = new Mydetails("moses", 25);
            player[2] = new Mydetails("ruth", 3);
            player[3] = new Mydetails("sam", 23);
        }

        
        public IEnumerator GetEnumerator()
        {
            return player.GetEnumerator();
        }
    }

}
