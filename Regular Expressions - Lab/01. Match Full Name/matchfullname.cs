using System;
using System.Text.RegularExpressions;
 
namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z][a-z]{1,}) ([A-Z][a-z]{1,})\b";
 
            string input = Console.ReadLine();
 
            MatchCollection matches = Regex.Matches(input, pattern);
 
            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}