using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var townName = Console.ReadLine();
            var population = int.Parse(Console.ReadLine());
            var area = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }

    }

}