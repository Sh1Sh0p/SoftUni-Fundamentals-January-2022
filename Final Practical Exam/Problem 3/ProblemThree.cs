using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace 03.DegustationParty
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> theGuests = new Dictionary<string, List<string>>();
            int counterForUnliked = 0;
            string action = Console.ReadLine();
            while (action != "Stop")
            {
                string[] parts = action.Split("-");
                string command = parts[0];

                if (command == "Like")
                {
                    string guest = parts[1];
                    string food = parts[2];
                    if (theGuests.ContainsKey(guest))
                    {

                        if (theGuests[guest].Contains(food))
                        {

                        }
                        else
                        {
                            theGuests[guest].Add(food);
                        }
                    }
                    else
                    {
                        theGuests.Add(guest, new List<string>() { food });
                    }
                }
                else if (command == "Dislike")
                {
                    string guest = parts[1];
                    string food = parts[2];

                    if (theGuests.ContainsKey(guest))
                    {
                        if (theGuests[guest].Contains(food))
                        {
                            theGuests[guest].Remove(food);
                            counterForUnliked++;
                            Console.WriteLine($"{guest} doesn't like the {food}.");
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {food} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }

                }
                action = Console.ReadLine();
            }

            foreach (var item in theGuests)
            {
                int foodsCounter = item.Value.Count;
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");

            }
            Console.WriteLine($"Unliked meals: {counterForUnliked}");
        }
    }
}
