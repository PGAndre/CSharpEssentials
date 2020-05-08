using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_4
{
    class Timing
    {
        private DateTime time;
        public DateTime Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }

        public Timing(DateTime time)
        {
            this.time = time;
        }

        public static int operator -(Timing time1, Timing time2)
        {
            TimeSpan timespan = time1.Time - time2.Time;
            return timespan.Days;
        }

        public static Timing PlusDays(Timing time1, int days)
        {
            DateTime newDate = time1.Time.AddDays(days);
            return new Timing(newDate);
        }

        public override string ToString()
        {
            return "Date: " + time;
        }




    }
}
