using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT 
            var country = Console.ReadLine();
            //OUTPUT
            switch (country)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;

                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;

                default:
                    Console.WriteLine("unknown");
                  break;
            }
        }

    }

}