using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var ageGroup = "";

            if (age >= 0 && age <= 2)
            {
                ageGroup = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                ageGroup = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                ageGroup = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                ageGroup = "adult";
            }
            else
            {
                ageGroup = "elder";
            }

            Console.WriteLine(ageGroup);
        }
    }
}