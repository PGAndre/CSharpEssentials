using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_2
{
    public class Mylist<T> : IMylist<T>
    {
       public T[] massive;

        public Mylist()
        {
            massive = new T[0];
        }
        public void Add(T a)
        {
            T[] tempmassive = new T[massive.Length + 1];
            for (int i = 0; i < massive.Length; i++)
            {
                tempmassive[i]= massive[i];
            }
            tempmassive[massive.Length] = a;
            massive = tempmassive;
        }

        public T this[int index]
        {
            get
            {
                return massive[index];
            } 
        }

        public int this[T value]
        {
            get
            {
                for (int i = 0; i < massive.Length; i++)
                {
                    if ((string)(object)massive[i] == (string)(object)value)
                    {
                        return i;
                    }
                }
                return 0;
            }

        }
        public int Count
        {
            get
            {
                return massive.Length;
            }
        }

        public bool Exist(T b)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                if(massive[i].ToString() == b.ToString())
                {
                    return true;
                }
            }
            return false;

        }
          
    }
}
