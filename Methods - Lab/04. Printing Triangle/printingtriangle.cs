using System;
using System.Drawing;

namespace PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangleHeight = int.Parse(Console.ReadLine());

            for (int i = 1; i <= triangleHeight; i++)
            {
                PrintLine(1, i);
            }

            for (int i = triangleHeight - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}