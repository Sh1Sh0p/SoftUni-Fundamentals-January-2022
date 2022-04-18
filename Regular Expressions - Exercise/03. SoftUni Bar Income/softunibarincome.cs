using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%{1}(?<name>[A-Z][a-z]+)\%{1}(([^%$.|])*?)\<(?<product>\w+)\>(([^^%$.|])*?)\|(?<count>\d+)\|(([^^%$.|])*?)(?<price>\d+((.\d+)?))\$";

            double totalIncome = 0.0;
            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    Console.WriteLine($"{name}: {product} - {(count * price):f2}");
                    totalIncome += count * price;
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}