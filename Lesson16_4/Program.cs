using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Timing time1 = new Timing(DateTime.Now);
            Timing time2 = new Timing(new DateTime(2019, 05, 07));
            int daysDiff = time1 - time2;
            Console.WriteLine(time1.Time.Month);
            Console.WriteLine(daysDiff);

            Timing newdate = Timing.PlusDays(time1, 1);
            Console.WriteLine(newdate);



            Console.ReadLine();
        }
    }
}
