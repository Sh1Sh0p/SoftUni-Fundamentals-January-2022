using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace CenturiesToMINs
{
    class Program
    {
        static void Main(string[] args)
        {
            const int YearsInCenturyCount = 100;
            const decimal DaysInAnYear = 365.2422m;
            const int HoursInADay = 24;
            const int MinutesInAHour = 60;

            var centuries = int.Parse(Console.ReadLine());

            int years = centuries * YearsInCenturyCount;
            int days = (int)(years * DaysInAnYear);
            int hours = days * HoursInADay;
            int minutes = hours * MinutesInAHour;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }

    }

}