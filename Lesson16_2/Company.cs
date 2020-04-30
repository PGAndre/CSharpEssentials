using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_2
{
    class Company
    {
        Worker[] staff;
        string name;
        string post;
        int year;
        int tmpYear;
        public Company()
        {
            staff = new Worker[3];

            for (int i = 0; i < staff.Length; i++)
            {
                Console.WriteLine("Введите имя сотрудника");
                name = Console.ReadLine();

                Console.WriteLine("Введите должность сотрудника");
                post = Console.ReadLine();

                Console.WriteLine("Введите дату начала работы сотрудника");
                try
                {
                    tmpYear = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Задан неверный формат даты");
                    Console.WriteLine(e.Message);
                    year = DateTime.Now.Year;
                }
                year = tmpYear;

                staff[i] = new Worker(name, post, year);
                Console.Clear();
            }
        }

        public string ExperiencedStaff(int Exp)
        {
            string expstaff = "";
            for (int i = 0; i < staff.Length; i++)
            {
                if (staff[i].Experience()>=Exp)
                {
                    expstaff += staff[i].Name + staff[i].Post + '\n';
                }
            }
            return expstaff;
        }
    }
}

