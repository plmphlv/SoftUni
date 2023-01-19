using System.Collections.Generic;
using System;
using System.Linq;

namespace E08.SoftUniParty
{
    internal class SoftUniParty
    {
        static void Main(string[] args)
        {
            HashSet<string> guestList = new HashSet<string>();


            string command;

            while ((command = Console.ReadLine()) != "PARTY")
            {
                if (command.Length == 8)
                {
                    guestList.Add(command);
                }
            }

            while ((command = Console.ReadLine()) != "END")
            {
                if (command.Length == 8)
                {
                    guestList.Remove(command);
                }
            }


            guestList = guestList.OrderByDescending(x => char.IsDigit(x.First())).ToHashSet();

            Console.WriteLine(guestList.Count);

            Console.WriteLine(String.Join(Environment.NewLine, guestList));




        }
    }
}