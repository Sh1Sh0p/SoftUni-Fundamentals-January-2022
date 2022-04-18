using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConvertMetersToKMs
{
    class Program
    {
        static void Main(string[] args)
        {
            var meters = double.Parse(Console.ReadLine());
            var kilometeres = meters / 1000.00;
            Console.WriteLine($"{Math.Round(kilometeres, 2, MidpointRounding.AwayFromZero):F2}");
        }

    }

}