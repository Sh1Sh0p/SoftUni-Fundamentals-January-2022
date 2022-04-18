using System;
using System.Collections.Generic;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();

            string command;
            while ((command = Console.ReadLine()) != "stop")
            {
                string resource = command;
                int quantity = int.Parse(Console.ReadLine());

                if (materials.ContainsKey(resource))
                {
                    materials[resource] += quantity;
                    continue;
                }

                materials[resource] = quantity;
            }

            foreach (KeyValuePair<string, int> material in materials)
            {
                Console.WriteLine($"{material.Key} -> {material.Value}");
            }

        }
    }
}