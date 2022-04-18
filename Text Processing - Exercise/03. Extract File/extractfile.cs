using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string[] fileInfo = file
                .Split("\\", StringSplitOptions.RemoveEmptyEntries)
                .Last()
                .Split('.', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string fileName = String.Join('.', fileInfo.Take(fileInfo.Length-1));
            string fileExtension = fileInfo.Last();

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}