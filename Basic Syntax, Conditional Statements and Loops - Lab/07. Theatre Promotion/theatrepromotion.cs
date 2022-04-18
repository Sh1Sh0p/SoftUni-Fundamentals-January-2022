using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT 
            var typeOfDay = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var price = 0;

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }

            //OUTPUT
            switch (typeOfDay)
            {              
                case "Weekday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 12;
                    }
                    else if (age <= 64)
                    {
                        price = 18;
                    }
                    else if (age <= 122)
                    {
                        price = 12;
                    }
                    break;

                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        price = 15;
                    }
                    else if (age <= 64)
                    {
                        price = 20;
                    }
                    else if (age <= 122)
                    {
                        price = 15;
                    }
                    break;

                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                    }
                    else if (age <= 64)
                    {
                        price = 12;
                    }
                    else if (age <= 122)
                    {
                        price = 10;
                    }
                    break;
            }

            Console.WriteLine($"{price}$");

        }

    }

}