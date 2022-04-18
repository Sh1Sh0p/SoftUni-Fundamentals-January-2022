using System;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort peopleCount = ushort.Parse(Console.ReadLine());
            sbyte capacity = sbyte.Parse(Console.ReadLine());

            ushort courses = (ushort)(peopleCount / capacity);

            if (peopleCount % capacity != 0)
            {
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}