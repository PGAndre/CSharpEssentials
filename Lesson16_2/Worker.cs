using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_2
{
    class Worker
    {
        string name;
        string post; //должность
        int year;

        public string Name { get => name; set => name = value; }
        public string Post { get => post; set => post = value; }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value <= DateTime.Now.Year && DateTime.Now.Year - value <= 60)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("вы ввели недопустимое значение, повторите ввод");
                    Year = Convert.ToInt32(Console.ReadLine());
                }
            }

        }

        public Worker(string name, string post, int year)
        {
            this.year = DateTime.Now.Year;
            this.name = name;
            this.post = post;
            this.Year = year;
        }

        public int Experience()
        {
            return DateTime.Now.Year - year;
        }


    }
}
