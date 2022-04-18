using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());

            if (char.IsUpper(character))
            {
                Console.WriteLine("upper-case");
            }
            else if (char.IsLower(character))
            {
                Console.WriteLine("lower-case");
            }
        }

    }

}