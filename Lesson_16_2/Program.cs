using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(1, 2, 3, 4);
            Block block2 = new Block(2, 3, 1, 4);


            Console.WriteLine(block1.ToString());
            Console.WriteLine(block2.ToString());
            Console.WriteLine(block1.Equals(block2));
            

            if (block1.GetHashCode() == block2.GetHashCode())
            {
                Console.WriteLine("Параметры блоков равны");
            }
            else
            {
                Console.WriteLine("Параметры блоков не равны");
            }

            Console.ReadLine();


        }
    }
}
