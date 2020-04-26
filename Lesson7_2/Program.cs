using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Train[] trains = new Train[3];
            //TuTu tutu = new TuTu();
            TuTu.CreateTrain(trains);
            TuTu.Show(trains);
            TuTu.Sort(ref trains);
            TuTu.Show(trains);
            Console.ReadLine();
        }
    }
}
