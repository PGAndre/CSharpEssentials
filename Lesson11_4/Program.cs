using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson10_2;

namespace Lesson11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();

            list.Add("porche");
            list.Add(5);
            list.Add(5.6);
            list.Add('g');

            Console.WriteLine(list.Count);

            Console.WriteLine(list.ToString());

            Console.WriteLine(list[1]);
            Console.WriteLine(list[0]);

            Console.ReadKey();


        }
    }
}
