using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BackInThirtyMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT 
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 30;
            //OUTPUT
            if (minutes >= 60)
            {
                hours++;
                minutes = minutes - 60;
            }
            if (hours >= 24)
            {
                hours = 24 - hours;
            }

            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }

    }

}