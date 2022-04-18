using System;

namespace PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int begining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int character = begining; character <= end; character++)
            {
                char symbol = (char)(character);
                Console.Write($"{symbol.ToString()} ");
            }
        }
    }
}