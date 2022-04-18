using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace NumsInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }


        }
    }
}