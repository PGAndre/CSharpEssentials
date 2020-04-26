using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson10_2;

namespace Lesson11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> Mydict = new MyDictionary<string, string>();

            Mydict.AddDictionary("стол", "table");
            Mydict.AddDictionary("словарь", "dictionary");
            Mydict.AddDictionary("козел", "goat");
            Console.WriteLine(Mydict["стол"]);
            Console.WriteLine(Mydict["козел"]);
            Console.WriteLine(Mydict.ToString());
            Console.ReadKey();
        }
    }
}
