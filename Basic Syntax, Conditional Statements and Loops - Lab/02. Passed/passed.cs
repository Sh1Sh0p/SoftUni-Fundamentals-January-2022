using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            var grade = double.Parse(Console.ReadLine());
            //OUTPUT

            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else if (grade < 3.00)
            {
                return;
            }
        }

    }

}