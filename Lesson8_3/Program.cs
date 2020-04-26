using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите кол-во отработанных часов");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("введите вашу должность");
            string post = Console.ReadLine();

            object element = Enum.Parse(typeof(Post), post);
            Post stringpost = (Post)element;

            /*            Post Profession(string professiya)
                        {
                            if (post == "Developer")
                            {

                                Post d = Post.Developer;
                                return d;

                            }
                            else
                                return 0;
                        }

                         Post dolzhn = Profession(post);*/

/*            Post d = 0;
            *//*            string g = Post.Developer.ToString();
                        Console.WriteLine(g+"1111");*//*
            if (post == Post.Developer.ToString())
            {
                Console.WriteLine("должность - девелопер");
                d = Post.Developer;
                //Console.WriteLine(d.GetType());
                // Console.WriteLine(d);
            }

            else if (post == Post.manager.ToString())
            {
                Console.WriteLine("должность - manager");
                d = Post.manager;
                //Console.WriteLine(d.GetType());
                // Console.WriteLine(d);
            }
            else if (post == Post.ITManager.ToString())
            {
                Console.WriteLine("должность - ITManager");
                d = Post.ITManager;
                //Console.WriteLine(d.GetType());
                // Console.WriteLine(d);
            }

            else if (post == Post.Helpdesk.ToString())
            {
                Console.WriteLine("должность - Helpdesk");
                d = Post.Helpdesk;
                //Console.WriteLine(d.GetType());
                // Console.WriteLine(d);
            }

            else if (post == Post.Sysadmin.ToString())
            {
                Console.WriteLine("должность - Sysadmin");
                d = Post.Sysadmin;
                //Console.WriteLine(d.GetType());
               // Console.WriteLine(d);
            }

          //  Console.WriteLine(d + "должность");
            //Console.WriteLine(post);
*/

            //Console.WriteLine(d + "должность");
            if (Accauntant.AskforBonus(stringpost,hours))
            {
                Console.WriteLine("выдать премию");
            }
            else
            {
                Console.WriteLine("Не выдать премию");
            }
            Console.ReadLine();

        }
    }
}
