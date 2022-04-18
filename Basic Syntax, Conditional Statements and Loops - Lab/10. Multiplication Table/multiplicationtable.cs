using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var theInteger = int.Parse(Console.ReadLine());
            var times = 1;

            while (times <= 10)
            {
                var product = theInteger * times;
                Console.WriteLine($"{theInteger} X {times} = {product}");
                times++;
            }

        }

    }

}