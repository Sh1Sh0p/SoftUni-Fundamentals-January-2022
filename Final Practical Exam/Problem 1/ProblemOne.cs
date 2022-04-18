using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Numerics;

namespace 01.StringGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = Console.ReadLine();

            string cmnd = Console.ReadLine();

            while (cmnd != "Done")
            {
                string[] cmndArg = cmnd.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string kindOfCmnd = cmndArg[0];

                if (kindOfCmnd == "Change")
                {
                    char chrChng = char.Parse(cmndArg[1]);

                    char chrRplc = char.Parse(cmndArg[2]);

                    msg = msg.Replace(chrChng, chrRplc);

                    Console.WriteLine(msg);
                }

                else if (kindOfCmnd == "Includes")
                {
                    string sString = cmndArg[1];

                    if (msg.Contains(sString))
                    {
                        Console.WriteLine("True");
                    }

                    else
                    {
                        Console.WriteLine("False");
                    }
                }

                else if (kindOfCmnd == "End")
                {
                    string findEndWord = cmndArg[1];

                    End(findEndWord, msg);
                }

                else if (kindOfCmnd == "Uppercase")
                {
                    msg = msg.ToUpper();

                    Console.WriteLine(msg);
                }

                else if (kindOfCmnd == "FindIndex")
                {
                    string findIndex = cmndArg[1];

                    int startIndexChar = msg.IndexOf(findIndex);

                    Console.WriteLine(startIndexChar);
                }

                else if (kindOfCmnd == "Cut")
                {
                    int startIndex = int.Parse(cmndArg[1]);

                    int countRemove = int.Parse(cmndArg[2]);

                    msg = msg.Substring(startIndex, countRemove);

                    Console.WriteLine(msg);
                }

                cmnd = Console.ReadLine();
            }
        }

        static bool End(string endWord, string input)
        {
            bool result = input.EndsWith(endWord);

            if (result)
            {
                Console.WriteLine("True");
                return result;
            }

            else
            {
                Console.WriteLine("False");
                return result;
            }
        }
    }
}