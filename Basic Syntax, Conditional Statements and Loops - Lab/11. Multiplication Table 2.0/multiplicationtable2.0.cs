using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MultiplicationTableSecondVers
{
    class Program
    {
        static void Main(string[] args)
        {
            var theInteger = int.Parse(Console.ReadLine());
            var secondInteger = int.Parse(Console.ReadLine());
            var times = 1;

            var product = theInteger * secondInteger;
                
                if (secondInteger > 10)
                {
                    Console.WriteLine($"{theInteger} X {secondInteger} = {product}");
                    return;
                } 
                else if (secondInteger <= 10)
                {
                    while (secondInteger <= 10)
                    {
                    Console.WriteLine($"{theInteger} X {secondInteger} = {product}");
                    secondInteger++;
                    product = theInteger * secondInteger;
                    }
                }
            

        }

    }

}