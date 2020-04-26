using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson10_2;

namespace Lesson11_2
{
    class CarCollection
    {
        Mylist<string> CarName;
        Mylist<DateTime> CarDate;

        public CarCollection()
        {
            CarName = new Mylist<string>();
            CarDate = new Mylist<DateTime>();
        }

        public void Add(string carname, DateTime date)
        {
            CarName.Add(carname);
            CarDate.Add(date);
        }

        public string this[int index]
        {
            get
            {
                if (index < CarName.Count)
                {
                    return "автомобиль " + CarName[index] + " " + CarDate[index] + " года выпуска";
                }
                return "несуществующий индекс";
            }
        }

        public string this[string carname]
        {
            get
            {
                for (int i = 0; i < CarName.Count; i++)
                {
                    if (CarName[i]==carname)
                    {
                        return "автомобиль " + CarName[i] + " " + CarDate[i] + " года выпуска gg";
                    }
                }
                return "нет такого автомобиля";
            }
            
            
        }

        public int CountCars
        {
            get 
            {
                return CarName.Count;
            }
        }


    }
}
