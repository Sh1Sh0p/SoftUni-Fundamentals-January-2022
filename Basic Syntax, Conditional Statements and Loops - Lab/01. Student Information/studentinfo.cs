using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            var studentName = Console.ReadLine();
            var studentAge = int.Parse(Console.ReadLine());
            var studentAvrgGrade = double.Parse(Console.ReadLine());
            //OUTPUT

            Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {studentAvrgGrade:F2}");
        }

    }

}