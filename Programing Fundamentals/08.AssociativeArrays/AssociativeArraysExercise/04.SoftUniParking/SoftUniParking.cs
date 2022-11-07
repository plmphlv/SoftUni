using System;
using System.Collections.Generic;

namespace _04.SoftUniParking
{
    internal class SoftUniParking
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> licensePlates = new Dictionary<string, string>();
            int numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numOfCommands; i++)
            {

                string[] commandArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string mainCommand = commandArgs[0];
                string carOwner = commandArgs[1];

                switch (mainCommand)
                {

                    case "register":

                        string licensePlateNumber = commandArgs[2];

                        if (licensePlates.ContainsValue(licensePlateNumber))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }
                        else
                        {
                            licensePlates[carOwner] = licensePlateNumber;
                            Console.WriteLine($"{carOwner} registered {licensePlateNumber} successfully");
                        }

                        break;
                    case "unregister":

                        if (!licensePlates.ContainsKey(carOwner))
                        {
                            Console.WriteLine($"ERROR: user {carOwner} not found");
                        }
                        else
                        {
                            licensePlates.Remove(carOwner);
                            Console.WriteLine($"{carOwner} unregistered successfully");
                        }

                        break;

                }

            }

            foreach (var pair in licensePlates)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }

        }
    }
}