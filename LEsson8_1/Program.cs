using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEsson8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите текст");
            string text = Console.ReadLine();
            Console.WriteLine("введите цвет: 1- синий, 2 - красный, 3 - зеленый");
            int color = int.Parse(Console.ReadLine());
            Consol.WriteLine(text, color);
            Console.ReadLine();
        }
    }
}
