using System;

namespace IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());
            long sum = num1 + num2;

            long num3 = long.Parse(Console.ReadLine());
            long division = sum / num3;

            long num4 = long.Parse(Console.ReadLine());
            long multiplication = division * num4;

            Console.WriteLine(multiplication);
        }
    }
}