using System.Collections.Generic;
using System;
using System.Linq;

namespace E08.SoftUniParty
{
    internal class SoftUniParty
    {
        static void Main(string[] args)
        {
            HashSet<string> regularList = new HashSet<string>();
            HashSet<string> vipList = new HashSet<string>();

            string command;

            while ((command = Console.ReadLine()) != "PARTY")
            {
                if (command.Length == 8)
                {

                    if (char.IsDigit(command[0]))
                    {
                        vipList.Add(command);
                    }
                    else
                    {
                        regularList.Add(command);
                    }
                }
            }

            while ((command = Console.ReadLine()) != "END")
            {
                if (command.Length == 8)
                {

                    if (char.IsDigit(command[0]))
                    {
                        vipList.Remove(command);
                    }
                    else
                    {
                        regularList.Remove(command);
                    }
                }
            }


            Console.WriteLine(vipList.Count + regularList.Count);

            if (vipList.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, vipList));
            }

            if (regularList.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, regularList));
            }


        }
    }
}