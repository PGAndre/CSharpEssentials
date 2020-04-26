using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEsson6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("some text");
        }
    }

    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("поиск в книге: {0}", str);
            Console.ReadLine();
        }
    }

   static class FindAndReplaceManager
    {
        static public void FindNext(string str)
        {
            Book book = new Book();
            book.FindNext(str);
        }
    }
}
