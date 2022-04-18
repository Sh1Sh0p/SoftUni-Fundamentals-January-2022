using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var delimiter = Console.ReadLine();

            Console.WriteLine($"{firstName}{delimiter}{lastName}");
        }

    }

}