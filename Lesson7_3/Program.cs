using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_3
{
    class Program
    {
        static void StructTaker(ref MyStruct Mystruct)
        {
            Mystruct.change = "changed";
          //  Mystruct = new MyStruct();
        }
        static void ClassTaker(ref MyClass Myclass)
        {
            Myclass.change = "changed";
            Myclass = new MyClass();
        }
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            MyStruct mystruct = new MyStruct();

            myclass.change = "notchanged";
            mystruct.change = "notchanged";

            StructTaker(ref mystruct);
            ClassTaker(ref myclass);

            Console.WriteLine(myclass.change);
            Console.WriteLine(mystruct.change);

            Console.ReadKey();


        }
    }
}
