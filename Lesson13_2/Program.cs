using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Linq.Expressions;

namespace Lesson13_2
{
    class Symbol
    {
        public int x;
        public int y;
        public char Char;
        public Symbol(int X, int Y, char Char)
        {
            x = X;
            y = Y;
            this.Char = Char;
        }
        public void PrintSymbol(int x, int y, char Char)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x, y);
            Console.Write(Char);
        }
        public void DeleteSymbol(int x, int y, char Char)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x, y - 5);
            Console.Write(' ');
        }
    }

    static class SymbollFall
    {
        static Symbol symbol;
        /*        public SymbollFall(int x, int y, char Ch)
                {
                    symbol = new Symbol(x, y, Ch);
                }*/


    }

    class MyClass
    {
        object block = new object();
        public void MoveSymbol()
        {
            lock (block)
            {
                Random random = new Random();
                int x = random.Next(1, 100);
                int y = random.Next(1, 1);
                char Char = 'X';
                for (int i = 1; i < 20; i++)
                {
                    Symbol symbol = new Symbol(x, y, Char);
                    if (i < 5)
                    {
                        symbol.PrintSymbol(symbol.x, symbol.y + i, symbol.Char);
                        Thread.Sleep(100);
                    }
                    else
                    {
                        symbol.PrintSymbol(symbol.x, symbol.y + i, symbol.Char);
                        Thread.Sleep(100);
                        symbol.DeleteSymbol(symbol.x, symbol.y + i, symbol.Char);
                        Thread.Sleep(100);

                    }
                }
            }
        }
    }

        
        class Program
        {
            
            static void Main(string[] args)
            {
            MyClass instance = new MyClass();
            Thread.Sleep(100);
            MyClass instance2 = new MyClass();


            for (int i = 1; i < 3; i++)
            {
                new Thread(instance.MoveSymbol).Start();
            }

            for (int i = 1; i < 3; i++)
            {
                new Thread(instance2.MoveSymbol).Start();
            }


                /*            ThreadStart movesymbol = new ThreadStart(MoveSymbol);
                            Thread thread = new Thread(movesymbol);
                            thread.Start();



                            ThreadStart movesymbol2 = new ThreadStart(MoveSymbol);
                            Thread thread2 = new Thread(movesymbol2);
                            thread2.Start();*/

                /*            ThreadStart movesymbol3 = new ThreadStart(MoveSymbol);
                            Thread thread3 = new Thread(movesymbol3);
                            thread3.Start();

                            ThreadStart movesymbol4 = new ThreadStart(MoveSymbol);
                            Thread thread4 = new Thread(movesymbol4);
                            thread4.Start();
                */


                /*            SymbollFall symbfall = new SymbollFall(40,0,'x');
                            symbfall.MoveSymbol();*/

                /*
                            for (int i = 1; i < 120; i++)
                            {
                                Random random = new Random();
                                int j = random.Next(1, 30);
                                Symbol.PrintSymbol(i, j, 'X');
                                Symbol.PrintSymbol(i, j + 1, 'y');
                                Symbol.PrintSymbol(i, j + 2, 'i');
                                Symbol.PrintSymbol(i, j + 3, 'X');
                                Symbol.PrintSymbol(i, j + 4, 'y');
                                Symbol.PrintSymbol(i, j + 5, 'i');
                                Thread.Sleep(20);
                            }*/




                Console.ReadKey();
            }
        }
    }


