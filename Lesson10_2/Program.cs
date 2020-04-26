using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylist<int> myint = new Mylist<int>();
            myint.Add(1);
            myint.Add(12312);
            Console.WriteLine(myint[0]);
            Console.WriteLine(myint[1]);
            Console.WriteLine(myint.Count);
            Console.WriteLine(myint.Exist(5));


            Mylist<string> mystring = new Mylist<string>();
            mystring.Add("stroka");
            mystring.Add("ewe stroka");
            Console.WriteLine(mystring[0]);
            Console.WriteLine(mystring[1]);
            Console.WriteLine(mystring.Count);
            Console.WriteLine(mystring.Exist("strhoka"));
            Console.WriteLine(mystring["stroka"]);

            Console.ReadKey();
        }
    }
}
