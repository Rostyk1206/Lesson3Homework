using System;

namespace Lesson3Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 9;
            int operand2 = 5;
            Console.WriteLine("Choose arithmethic operation:'+' '-' '*' '/'");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case ("*"):
                {
                    int result = operand1 * operand2;
                    Console.WriteLine($"Result:{result}");
                    break;
                }
                case ("+"):
                    {
                        int result = operand1 + operand2;
                        Console.WriteLine($"Result:{ result}");
                        break;
                    }
                case ("-"):
                    {
                        int result = operand1 - operand2;
                        Console.WriteLine($"Result:{ result}");
                        break;
                    }
                case ("/"):
                    {
                        if (operand2 == 0)
                        {
                            Console.WriteLine("You cannot divide by zero");
                        }
                        double result = 9.0 / operand2;
                        Console.WriteLine($"Result:{ result}");
                        break;
                    }
            }
        }
    }
}
