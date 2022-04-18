using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var digit = int.Parse(Console.ReadLine());

            while (true)
            {
                if (digit % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                    digit = int.Parse(Console.ReadLine());
                }
                else if (digit % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(digit)}");
                    return;
                }
            }
        }

    }

}