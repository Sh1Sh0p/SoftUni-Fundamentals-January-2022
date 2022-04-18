using System;
using System.Linq;

namespace RectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = GetRectangleArea(width, height);
            Console.WriteLine(area);
        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}