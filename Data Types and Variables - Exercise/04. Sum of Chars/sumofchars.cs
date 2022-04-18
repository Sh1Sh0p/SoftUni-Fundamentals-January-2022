using System;

namespace SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += letter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}