using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_2
{
    public interface IMylist<T>
    {
        void Add(T b);
        T this[int index] { get; }

        int Count { get; }

        bool Exist(T b);
    }
}
