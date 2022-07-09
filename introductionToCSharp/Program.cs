
using introductionToCSharp.Student;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace introductionToCSharp
{
    //preprocessor directives
    //Icollection, Ilist and List
  
    class Program
    {
        //Icollection,Ilist,list
        //set or Hashset
        //stack -- Lifo => LastIn-FirstOut
        //queue-- FIFO => firt in - first out
        //Dictionary

        private static Dictionary<string,object> dict;
        static void Main()
        {
            dict = new Dictionary<string, object>();
            Add("pi", 3.141);
            Add("Bread", "Bread is made of flour, sugar and oil");
            Add("Colonge", "Nice Deodorant for the body");
            Add("Numbers", 123453);

            string result = Console.ReadLine();
            Console.WriteLine(result + GetAnyvalue<object>(result));

            #region
            //Stack<int> stack = new Stack<int>();
            //stack.Push(2);
            //stack.Push(4);
            //stack.Push(5);
            //Console.WriteLine(stack.Peek());
            //stack.Pop();
            //Console.WriteLine(stack.Peek());
            //stack.Pop();
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine("****************");
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(5);
            //Console.WriteLine(queue.Peek());
            //queue.Dequeue();
            //Console.WriteLine(queue.Peek());
            //queue.Dequeue();
            //Console.WriteLine(queue.Peek());


            //List<string> mylist = new List<string>();
            //mylist.Add("joy");
            //mylist.Add("grace");
            //mylist.Add("ben");
            //mylist.Add("todd");
            //mylist.Add("sam");
            //mylist.Add("sam");

            //string[] array = { "books", "pen", "chalk", "books", "eraser","books" };
            //Console.WriteLine(string.Join(",", array));

            //var h = new HashSet<string>(array);

            //string[] arry2 = h.ToArray();
            //Console.WriteLine(string.Join(",",arry2));

            //Display(mylist);
            //GenericDisplay(mylist);
            //DIsplayAll(mylist);
            #endregion


        }

        private static T GetAnyvalue<T>(string stkey)
        {
            object obj;
            T retType;

            dict.TryGetValue(stkey, out obj);
            try
            {
                retType = (T)obj;
            }
            catch
            {
                retType = default(T);
            }

            return retType;
        }

        public static void Add(string strkey, object data)
        {
            if(!dict.ContainsKey(strkey))
            {
                dict.Add(strkey, data);
            }
            else
            {
                dict[strkey] = data;
            }
        }

        #region
        private static void DIsplayAll(ICollection<string> mylist)
        {
            mylist.Add("joy");
            foreach (var item in mylist)
            {
                Console.WriteLine("the ICollection elements are as follow" + item);
               
            }
        }

        private static void GenericDisplay(IList<string> mylist)
        {
            mylist.Add("joy");
            foreach (var item in mylist)
            {
                Console.WriteLine("the Ilist elements are as follow" + item);
            }
        }

        private static void Display(List<string> mylist)
        {
            mylist.Add("joy");
            mylist.Sort();
            mylist.TrimExcess();
            foreach (var item in mylist)
            {
                Console.WriteLine("the List elements are as follow" + item);
            }
            
        }
        #endregion
    }






}





