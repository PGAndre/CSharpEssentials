using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_3
{
    delegate int RandomInt();
    delegate double Average(RandomInt[] a);
    class Program
    {
        static void Main(string[] args)
        {
            int Randomizer()
            {
                int r = new Random().Next(100);
                System.Threading.Thread.Sleep(r);
                return r;
            }

            RandomInt[] random = new RandomInt[3];

            for (int i = 0; i < random.Length; i++)
            {
                random[i] = Randomizer;
            }

            Average average = delegate(RandomInt[] c)
            {
                int summ = 0;
                for (int i = 0; i < c.Length; i++)
                {
                    Console.Write(c[i].Invoke() + " ");
                    summ += c[i].Invoke();
                }
                return summ / c.Length;
            };



/*           for (int i = 0; i < random.Length; i++)
            {
                Console.Write(random[i]()+ " ");
            }*/

            Console.WriteLine("1");
            Console.WriteLine(average(random));
            //Console.WriteLine(Randomizer());
            Console.ReadLine();
        }
    }
}
