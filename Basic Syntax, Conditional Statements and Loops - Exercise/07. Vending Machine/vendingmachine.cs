using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalCoins = 0.0;
            var productName = ;
            var flag = true;
            var productPrice = 0.0;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == Start)
                {
                    break;
                }

                var coins = double.Parse(input);

                switch (coins)
                {
                    case 2.0
                    case 1.0
                    case 0.5
                    case 0.2
                    case 0.1
                        totalCoins += coins;
                        break;
                    default
                        Console.WriteLine($Cannot accept {coins});
                        break;
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == End)
                {
                    break;
                }

                switch (input)
                {
                    case Nuts
                        productPrice = 2;
                        break;
                    case Water
                        productPrice = 0.7;
                        break;
                    case Crisps
                        productPrice = 1.5;
                        break;
                    case Soda
                        productPrice = 0.8;
                        break;
                    case Coke
                        productPrice = 1;
                        break;
                    default
                        break;
                }

                if ((productPrice - totalCoins)  0)
                {
                    Console.WriteLine(Sorry, not enough money);
                    continue;
                }

                flag = true;

                switch (input)
                {
                    case Nuts
                        totalCoins -= productPrice;
                        productName = nuts;
                        break;
                    case Water
                        totalCoins -= productPrice;
                        productName = water;
                        break;
                    case Crisps
                        totalCoins -= productPrice;
                        productName = crisps;
                        break;
                    case Soda
                        totalCoins -= productPrice;
                        productName = soda;
                        break;
                    case Coke
                        totalCoins -= productPrice;
                        productName = coke;
                        break;
                    default
                        flag = false;
                        break;
                }

                if (flag)
                {
                    Console.WriteLine($Purchased {productName});
                }
                else
                {
                    Console.WriteLine(Invalid product);
                }
            }

            Console.WriteLine($Change {totalCoinsf2});
        }
    }
}