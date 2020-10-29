using System;

namespace Lesson3Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int number = int.Parse(Console.ReadLine());
            if (number>=0 && number<=14)
            {
                Console.WriteLine("[0-14]");
            }
            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine("[15-35]");
            }
            else if (number >= 36 && number <= 50)
            {
                Console.WriteLine("[36-50]");
            }
            else if (number >= 50 && number <= 100)
            {
                Console.WriteLine("[50-100]");
            }
            else
            {
                Console.WriteLine("Incorrect number");
            }

        }
    }
}
