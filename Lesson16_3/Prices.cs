using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_3
{
    struct Prices
    {
        string name;
        string shop;
        int price;

        public string Name
        {
            get { return name; }
            //set
            //{
            //    this.name = value;
            //}
        }

        public string Shop
        {
            get { return shop; }
            //set
            //{
            //    this.shop = value;
            //}
        }

        public int Price
        {
            get 
            {
                return price; 
            }
            set
            {
                if (value != 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("вы ввели неверное значение цены");
                    Price = Convert.ToInt32(Console.ReadLine());
                }
            }

        }
        public Prices(string name, string shop, int price)
        {
            this.price = 0;
            this.name = name;
            this.shop = shop;
            this.Price = price;
        }

        public void Show()
        {
            Console.WriteLine("товар {0} в магазине {1}, стоимость: {2}", name, shop, price);
        }

    }
}
