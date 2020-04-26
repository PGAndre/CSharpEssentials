using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson10_2;

namespace Lesson11_3
{
    class MyDictionary<TKey,TValue>
    {
        readonly Mylist<TKey> Tkey;
        readonly Mylist<TValue> Tvalue;

        public MyDictionary()
        {
            Tkey = new Mylist<TKey>();
            Tvalue = new Mylist<TValue>();
        }

        public void AddDictionary(TKey key, TValue value)
        {
            Tkey.Add(key);
            Tvalue.Add(value);
        }

        public string this[TKey key]
        {
            get
            {
                for(int i = 0;i < Tkey.Count; i++)
                {
                    if((string)(object)Tkey[i] == (string)(object)key)
                    {
                        return key.ToString().ToUpper() + " - " + Tvalue[i].ToString().ToUpper();
                    }
                }
                return "такого слова в словаре нет";
            }
        }

        public override string ToString()
        {
            string str = string.Empty;
            for (int i = 0; i < Tkey.Count; i++)
            {
                str += Tkey[i] + " " + Tvalue[i] + "\n";
            }
            if (str != null)
                return str;
            return "В словаре нет значений.";
        }
    }
}
