using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16_3
{
    class House
    {
        public int Number { get; set; }
        public int Floors { get; set; }

        private Street street;

        public Street Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }



        public House(Street street, int number,int floors)
            {
            Number = number;
            Floors = floors;
            this.street = street;
            }

        public House Clone()
        {
            return this;
        }

        public House DeepClone()
        {
            return new House((Street)street.Clone(), this.Number, this.Floors);
        }
    }
}
