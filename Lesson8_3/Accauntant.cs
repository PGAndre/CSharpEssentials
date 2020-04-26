using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
        using System.Threading.Tasks;

namespace Lesson8_3
{
    static class Accauntant
    {
        public static bool AskforBonus(Post worker, int hours)
        {
            if (hours >= (int)worker)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
