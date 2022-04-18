using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var correctPassword = string.Empty;
            var counter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                correctPassword += username[i];
            }

            while (true)
            {
                var password = Console.ReadLine();
                counter++;

                if (password == correctPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
            }
        }
    }
}