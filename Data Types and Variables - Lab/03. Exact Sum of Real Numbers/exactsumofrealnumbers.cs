using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal result = 0m;

            for (int i = 0; i < n; i++)
            {
                result += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(result);

        }

    }

}