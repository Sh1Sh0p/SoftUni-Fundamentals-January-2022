using System;
using System.Linq;
using System.Collections.Generic;

namespace WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var counts = new Dictionary<string, List<string>>();

            string key = string.Empty;

            for (int i = 1; i <= 2 * n; i++)
            {
                string input = Console.ReadLine();
                if (i % 2 != 0)
                {
                    key = input; // key updates regardless of its presence in counts

                    if (!(counts.ContainsKey(input)))
                    {
                        counts.Add(input, new List<string>());
                    }
                }
                else
                {
                    counts[key].Add(input);
                }
            }
            foreach (var word in counts)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}