
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Summ(1, 2));
          //неверно выдает решение при делимом == 0  
            if (Calculator.Division(123,0) != 0)
            {
                Console.WriteLine((Calculator.Division(123,0)));
            }
            else
                Console.WriteLine("na 0 delit` nezya");

            Console.ReadLine();
        }
    }

    static class Calculator
    {
       // static public double number1;
       //static public double number2;

        static Calculator()
        {
            
        }

        static public double Summ(double number1, double number2)
        {
            return number1 + number2;
        }

        static public double Division(double number1, double number2)
        {
            if (number2 == 0)
                return 0;
            else
                return number1 / number2;
        }


    }
}
