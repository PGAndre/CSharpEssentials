using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_4
{
    static class ArrangeArry
    {
        public static int[] Arrange(this int[] value)
        {
            int[] array = value;
            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 500, 200, 500, 200, 500 };

            //myArray.Arrange();


            // int[] arr = { 78, 55, 45, 98, 13 };

            int[] arranged = myArray.Arrange();
            Console.WriteLine("Sorted:");
            foreach (int p in arranged)
                Console.Write(p + " ");
            Console.Read();
        }

    }
}