using System;
using System.Collections.Generic;
using System.Linq;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> competitors = new Dictionary<string, int>();
            foreach (var item in names)
            {
                competitors[item] = 0;
            }

            string command;
            while ((command = Console.ReadLine()) != "end of race")
            {
                string name = null;
                int score = 0;

                foreach (char commandArgs in command)
                {
                    if (char.IsLetter(commandArgs))
                    {
                        name += commandArgs;
                    }
                    else if (char.IsDigit(commandArgs))
                    {
                        score += int.Parse(commandArgs.ToString());
                    }
                }

                if (competitors.ContainsKey(name))
                {
                    competitors[name] += score;
                }
            }

            string[] sortedCompetitorsByScore = competitors
                .OrderByDescending(x => x.Value)
                .Take(3)
                .Select(k => k.Key)
                .ToArray();
            Console.WriteLine
                ($"" +
                    $"1st place: {sortedCompetitorsByScore[0]} " +
                    $"\n2nd place: {sortedCompetitorsByScore[1]} " +
                    $"\n3rd place: {sortedCompetitorsByScore[2]}"
                );
        }
    }
}