using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var divisibleNum = 0;

            if (number % 10 == 0)
            {
                divisibleNum = 10;
            }
            else if (number % 7 == 0)
            {
                divisibleNum = 7;
            }
            else if (number % 6 == 0)
            {
                divisibleNum = 6;
            }
            else if (number % 3 == 0)
            {
                divisibleNum = 3;
            }
            else if (number % 2 == 0)
            {
                divisibleNum = 2;
            }

            if (divisibleNum == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {divisibleNum}");
            }
        }
    }
}