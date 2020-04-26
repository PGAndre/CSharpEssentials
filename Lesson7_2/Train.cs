using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_2
{
    struct Train
    {
        public string Destination;
        public DateTime DepartureTime;
        public int TrainID;

        public Train(string destination, DateTime departureTime, int trainID)
        {
            this.Destination = destination;
            this.DepartureTime = departureTime;
            this.TrainID = trainID;
        }
    }
}
