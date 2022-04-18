using System;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                char digit = input[i];
                sum += int.Parse(digit.ToString());
            }

            Console.WriteLine(sum);
        }
    }
}