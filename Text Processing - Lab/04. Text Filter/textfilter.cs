using System;
using System.Linq;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            string text = Console.ReadLine();

            foreach (var bannWord in bannedWords)
            {
                text = text.Replace(bannWord, new string('*', bannWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}