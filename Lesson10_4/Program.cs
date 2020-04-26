using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson10_2;

namespace Lesson10_4
{
    static class Program
    {
        public static T[] GetArray<T>(Mylist<T> array)
        {
            T[] arrayT = new T[array.massive.Length];
            for (int i = 0; i < array.massive.Length; i++)
            {
                arrayT[i] = array.massive[i];
            }
            return arrayT;
        }
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
            Console.WriteLine(mystring["stroka"]);
            Console.WriteLine(mystring.Count);
            Console.WriteLine(mystring.Exist("strhoka"));
            int[] a = myint.GetArray();

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }

            string[] str = mystring.GetArray();

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write("{0} ", str[i]);
            }


            Console.ReadKey();
        }
    }
}
