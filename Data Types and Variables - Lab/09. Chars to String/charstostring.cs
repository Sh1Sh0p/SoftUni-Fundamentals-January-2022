using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = Console.ReadLine();
            var secondChar = Console.ReadLine();
            var thirdChar = Console.ReadLine();

            Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
        }

    }

}