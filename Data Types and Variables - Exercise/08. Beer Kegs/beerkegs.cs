using System;

namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegsNum = int.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string biggestKegName = "";

            for (int i = 0; i < kegsNum; i++)
            {
                string kegName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (kegVolume > biggestKeg)
                {
                    biggestKeg = kegVolume;
                    biggestKegName = kegName;
                }
            }

            Console.WriteLine(biggestKegName);
        }
    }
}