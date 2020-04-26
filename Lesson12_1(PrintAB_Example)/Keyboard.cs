using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1_PrintAB_Example_
{

    public delegate void KeyboardHendler();
    class Keyboard
    {
        public event KeyboardHendler KeyA;
        public event KeyboardHendler KeyB;

        public void KeyHendlerA()
        {
            if (KeyA !=null)
            {
                KeyA.Invoke();
            }
                 }
        public void KeyHendlerB()
        {
            if (KeyB != null)
            {
                KeyB.Invoke();
            }
        }   

        public void Start()
        {
            while (true)
            {
                string bukva = Console.ReadLine();
                switch (bukva)
                {
                    case "a":
                        KeyHendlerA();
                        break;
                    case "b":
                        KeyHendlerB();
                        break;
                    default:
                        Console.WriteLine("введена неверная буква");
                        break;
                    case "quit":
                        goto quit;
                }   
            }
        quit:
            { }
          
                

        }
    }
}
