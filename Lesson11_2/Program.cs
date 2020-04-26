using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson10_2;

namespace Lesson11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection cars = new CarCollection();
            cars.Add("Audi", new DateTime(2020,01,12));
            cars.Add("Peugeot", new DateTime(2010, 11, 04));
            cars.Add("Porche", new DateTime(2018, 02, 13));
            cars.Add("Kia", new DateTime(2016, 01, 23));

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars["Kia"]);

            Console.WriteLine(cars.CountCars);
            Console.ReadKey();


        }
    }
}
