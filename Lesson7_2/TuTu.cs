using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_2
{
    static class TuTu
    {
               
       static public void CreateTrain(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                string destination;
                DateTime departureTime;
                int trainID;
                Console.WriteLine("введите пункт назначения:");
                destination = Console.ReadLine();
                Console.WriteLine("введите время отправления:");
                departureTime = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("введите номер поезда:");
                trainID = Convert.ToInt32(Console.ReadLine());
                trainID = trainID > 0 ? trainID : 0;

                //DateTime d = DateTime.Parse("15:00");
                trains[i] = new Train(destination,departureTime,trainID);
                // trains[1] = new Train();
                // trains[2] = new Train();
            }


        }

        static public void Show(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("поезд номер {0} отправится до {1} в {2}", trains[i].TrainID,trains[i].Destination,trains[i].DepartureTime);
            }
        }

        static public void Sort(ref Train[] trains)
        {
            Train temp;

            for (int write = 0; write < trains.Length; write++)
            {
                for (int sort = 0; sort < trains.Length - 1; sort++)
                {
                    if (trains[sort].TrainID > trains[sort + 1].TrainID)
                    {
                        temp = trains[sort + 1];
                        trains[sort + 1] = trains[sort];
                        trains[sort] = temp;
                    }
                }
                
            }
//            return trains;
        }
       
    }
}
