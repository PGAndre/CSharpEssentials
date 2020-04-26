using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEsson8_1
{
    static class Consol
    {
        static public void WriteLine(string stroka, int color)
        {
            switch (color)
            {
                case (int)ForeGroundColors.blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)ForeGroundColors.red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)ForeGroundColors.green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.WriteLine("Неверное значение цвета");
                    break;
            }
            Console.WriteLine(stroka);
        }
    }
}
