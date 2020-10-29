using System;
using System.Text;

namespace Lesson3Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Choose word: телефон, ручка, зошит, телевізор, сумка, вікно, ноутбук, басейн, вода, дощ ");
            Console.WriteLine("Enter your word:");
            string i = Console.ReadLine();          

            switch(i)
            {
                case ("телефон"):
                {
                        Console.WriteLine("Phone");
                        break;
                }
                case ("ручка"):
                    {
                        Console.WriteLine("Pen");
                        break;
                    }
                case ("зошит"):
                    {
                        Console.WriteLine("Copybook");
                        break;
                    }
                case ("телевізор"):
                    {
                        Console.WriteLine("TV");
                        break;
                    }
                case ("сумка"):
                    {
                        Console.WriteLine("Bag");
                        break;
                    }
                case ("вікно"):
                    {
                        Console.WriteLine("Window");
                        break;
                    }
                case ("ноутбук"):
                    {
                        Console.WriteLine("Laptop");
                        break;
                    }
                case ("басейн"):
                    {
                        Console.WriteLine("Pool");
                        break;
                    }
                case ("вода"):
                    {
                        Console.WriteLine("Water");
                        break;
                    }
                case ("дощ"):
                    {
                        Console.WriteLine("Rain");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Sorry, there is no your word!");
                        break;
                    }
            }
        }
    }
}
