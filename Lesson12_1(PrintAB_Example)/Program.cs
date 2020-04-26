using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1_PrintAB_Example_
{
    class Program
    {
        static public void KeyboardAHendler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("    X    ");
            Console.WriteLine("   X X   ");
            Console.WriteLine("  X   X  ");
            Console.WriteLine(" XXXXXXX ");
            Console.WriteLine("X       X");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static public void KeyboardBHendler()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("XXXXX  ");
            Console.WriteLine("X    X ");
            Console.WriteLine("XXXXXX ");
            Console.WriteLine("X     X");
            Console.WriteLine("XXXXXX ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void Main(string[] args)
        {
            Keyboard keyboard = new Keyboard();
            keyboard.KeyA += KeyboardAHendler;
            keyboard.KeyB += KeyboardBHendler;

            keyboard.Start();
        }
    }
}
