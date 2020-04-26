using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson10_2;

namespace Lesson11_4
{
    public class MyArrayList
    {
        public object[] massive;

        public MyArrayList()
        {
            massive = new object[0];
        }
        public void Add(object a)
        {
            object[] tempmassive = new object[massive.Length + 1];
            for (int i = 0; i < massive.Length; i++)
            {
                tempmassive[i] = massive[i];
            }
            tempmassive[massive.Length] = a;
            massive = tempmassive;
        }

        public object this[int index]
        {
            get
            {
                return massive[index];
            }
        }
        public int Count
        {
            get
            {
                return massive.Length;
            }
        }

        public bool Exist(object b)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] == b)
                {
                    return true;
                }
            }
            return false;

        }

        public string ToString()
        {
            string str = null;
            for (int i=0; i < massive.Length; i++)
            {
                str += massive[i].ToString() + " ";
            }
            return "всего " + massive.Length + "элементов: " + str;
        }

    }
}
