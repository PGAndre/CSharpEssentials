using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Company comp = new Company();
            // Console.WriteLine(comp[5]);
            string STAFF = comp.ExperiencedStaff(10);
            Console.WriteLine(STAFF);
            // Delay.
            Console.ReadKey();
        }
    }
}
