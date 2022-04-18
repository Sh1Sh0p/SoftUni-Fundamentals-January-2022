using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace 02.EncryptingPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPattern = @"(.+)>[0-9]{3}\|[a-z]{3}\|[A-Z]{3}\|[^\<\>]{3}<\1";

            string secondPattern = @"(?<first>[0-9]{3})\|(?<second>[a-z]{3})\|(?<third>[A-Z]{3})\|(?<forth>[^\<\>]{3})";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string pass = Console.ReadLine();

                Match match = Regex.Match(pass, firstPattern);

                if (match.Success)
                {
                    Match decrypt = Regex.Match(pass, secondPattern);

                    string firstMessage = (string)decrypt.Groups["first"].Value;

                    string secondMessage = (string)decrypt.Groups["second"].Value;

                    string thirdMessage = (string)decrypt.Groups["third"].Value;

                    string fourthMessage = (string)decrypt.Groups["forth"].Value;

                    string sixthMessage = firstMessage + secondMessage + thirdMessage + fourthMessage;

                    Console.WriteLine($"Password: {sixthMessage}");
                }

                else if (!match.Success)
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}