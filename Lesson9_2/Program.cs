using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_2
    {
    public delegate int Calculator(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
        Calculator Add = (int x, int y) => { return x + y; };
        Calculator Sub = (int x, int y) => { return x - y; };
        Calculator Div = (int x, int y) => { return x / y; };
        Calculator Mul = (int x, int y) => { return x * y; };



            Console.WriteLine("Введите Х:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип арифметический операции");
            string math = Console.ReadLine();

            switch (math)
            {
                case "+":
                    Console.WriteLine(Add(a,b));
                    break;
                case "-":
                    Console.WriteLine(Sub(a, b));
                    break;
                case "*":
                    Console.WriteLine(Mul(a, b));
                    break;
                case "/":
                    Console.WriteLine(Div(a, b));
                    break;
                default:
                    Console.WriteLine("Недопустимая операция");
                    break;
            }
            Console.ReadLine();





}
    }
}
