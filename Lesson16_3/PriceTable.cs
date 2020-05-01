using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_3
{
    class PriceTable
    {
        string name;
        string shop;
        int price;
        Prices[] prices = new Prices[2];

        public PriceTable()
        {
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("введите название товара");
                name = Console.ReadLine();

                Console.WriteLine("введите название магазина");
                shop = Console.ReadLine();

                Console.WriteLine("введите цену товара");
                
                try 
                {
                    price = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("вы ввели цену в неверном формате");
                    Console.WriteLine(e.Message);
                    price = 0;
                }

                prices[i] = new Prices(name, shop, price);
            }
        }
        public void Show()
        {
            for (int i=0; i < prices.Length; i++)
            {
                prices[i].Show();
            }
        }
    }
}
