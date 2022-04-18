using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = Console.ReadLine();
            var secondChar = Console.ReadLine();
            var thirdChar = Console.ReadLine();

            Console.WriteLine($"{thirdChar} {secondChar} {firstChar}");
        }
    }
}