using System;
using System.Collections.Generic;

namespace E07.ParkingLot
{
    internal class ParkingLot
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "IN":
                        cars.Add(cmdArgs[1]);
                        break;
                    case "OUT":
                        cars.Remove(cmdArgs[1]);
                        break;
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, cars));
        }
    }
}