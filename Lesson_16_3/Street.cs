using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16_3
{
    class Street : ICloneable
    {
        public string Str { get; set; }
        public Street(string str)
        {
            Str = str;
        }
        public object Clone()
        {
            return new Street(Str);
        }
    }
}
