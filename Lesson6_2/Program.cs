using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // FindAndReplaceManager.FindNext("some text");
            Book.Notes notes = new Book.Notes();
            notes.Text = "book";
            notes.Text = "is easy";
            Console.WriteLine(notes.Text);
            Console.ReadLine();
         
        }
    }

    class Book
    {
        public class Notes
        {
            string text = "";
            public string Text
            {
                get { return text; }
                set
                {
                    if (text != "")
                    {
                        text += "\n";
                    }
                    text += value;

                }
            }
        }
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
