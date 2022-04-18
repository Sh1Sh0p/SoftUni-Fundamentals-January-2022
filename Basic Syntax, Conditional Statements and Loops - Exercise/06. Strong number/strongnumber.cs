using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var convNum = Convert.ToString(num);
            var factorial = 1;
            var sum = 0;

            for (int i = 0; i <= convNum.Length - 1; i++)
            {
                char digits = convNum[i];
                int number = int.Parse(digits.ToString());
                factorial = 1;
                for (int j = number - 1; j > 0; j--)
                {
                    number *= j;
                    factorial = number;
                }
                sum += factorial;
            }

            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            } 
        }
    }
}