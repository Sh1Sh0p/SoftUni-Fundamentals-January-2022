using System;

namespace TripletsOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int ASCIINum = input + 96;

            for (char letter1 = (char)97; letter1 <= ASCIINum; letter1++)
            {
                for (char letter2 = (char)97; letter2 <= ASCIINum; letter2++)
                {
                    for (char letter3 = (char)97; letter3 <= ASCIINum; letter3++)
                    {
                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }
            }
        }
    }
}