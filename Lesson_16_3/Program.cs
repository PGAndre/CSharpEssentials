using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House(new Street("Bianki"), 11, 17);

            House house2 = house1.Clone();
            House house3 = house1.DeepClone();

            Console.WriteLine("первый дом: улица {0},  дом {1}, этаж {2}", house1.Street.Str, house1.Number, house1.Floors);
            Console.WriteLine("первый дом: улица {0},  дом {1}, этаж {2}", house2.Street.Str, house2.Number, house2.Floors);
            Console.WriteLine("первый дом: улица {0},  дом {1}, этаж {2}", house3.Street.Str, house3.Number, house3.Floors);


            Console.WriteLine(new string('-', 50));

            Console.WriteLine(house1.GetHashCode());
            Console.WriteLine(house2.GetHashCode());
            Console.WriteLine(house3.GetHashCode());

            house3.Street.Str = "Lokomotivniy";
            house3.Number = 13;
            house3.Floors = 2;
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("первый дом: улица {0},  дом {1}, этаж {2}", house1.Street.Str, house1.Number, house1.Floors);
            Console.WriteLine("первый дом: улица {0},  дом {1}, этаж {2}", house2.Street.Str, house2.Number, house2.Floors);
            Console.WriteLine("первый дом: улица {0},  дом {1}, этаж {2}", house3.Street.Str, house3.Number, house3.Floors);
            Console.WriteLine(new string('-', 50));

            house2.Street.Str = "Vishneviy";
            house2.Number = 16;
            house2.Floors = 4;

            Console.WriteLine("первый дом: улица {0},  дом {1}, этаж {2}", house1.Street.Str, house1.Number, house1.Floors);
            Console.WriteLine("первый дом: улица {0},  дом {1}, этаж {2}", house2.Street.Str, house2.Number, house2.Floors);
            Console.WriteLine("первый дом: улица {0},  дом {1}, этаж {2}", house3.Street.Str, house3.Number, house3.Floors);

            Console.ReadLine();
        }
    }
}
