using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleNum = int.Parse(Console.ReadLine());
            var groupType = Console.ReadLine();
            var weekDay = Console.ReadLine();
            var price = 0.0;
            var totalPrice = 0.0;

            if (groupType == "Students")
            {
                if (weekDay == "Friday")
                {
                    price = 8.45;
                }
                else if (weekDay == "Saturday")
                {
                    price = 9.80;
                }
                else if (weekDay == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (groupType == "Business")
            {
                if (weekDay == "Friday")
                {
                    price = 10.90;
                }
                else if (weekDay == "Saturday")
                {
                    price = 15.60;
                }
                else if (weekDay == "Sunday")
                {
                    price = 16;
                }
            }
            else if (groupType == "Regular")
            {
                if (weekDay == "Friday")
                {
                    price = 15;
                }
                else if (weekDay == "Saturday")
                {
                    price = 20;
                }
                else if (weekDay == "Sunday")
                {
                    price = 22.50;
                }
            }

            totalPrice = peopleNum * price;

            if (groupType == "Students" && peopleNum >= 30)
            {
                totalPrice -= (totalPrice * 0.15);
            }
            else if (groupType == "Business" && peopleNum >= 100)
            {
                totalPrice -= (price * 10);
            }
            else if (groupType == "Regular" && peopleNum >= 10 && peopleNum <= 20)
            {
                totalPrice -= (totalPrice * 0.05);
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}