using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_3
{
    class Model
    {
        public int Event1(string x,string y)
        {
            int X = Convert.ToInt32(x);
            int Y = Convert.ToInt32(y);
            return X + Y;
        }
    }
}
