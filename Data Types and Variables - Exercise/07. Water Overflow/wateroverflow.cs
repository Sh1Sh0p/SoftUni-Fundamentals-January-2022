using System;

namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            int input = int.Parse(Console.ReadLine());
            int pouredWater = 0;

            for (int i = 0; i < input; i++)
            {
                int litersOfWater = int.Parse(Console.ReadLine());
                bool flag = false;

                if (litersOfWater > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    flag = true;
                    continue;
                }
                else
                {
                    tankCapacity -= litersOfWater;
                    pouredWater += litersOfWater;
                }
            }

            Console.WriteLine(pouredWater);
        }
    }
}