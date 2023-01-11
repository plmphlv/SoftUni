using System;
using System.Collections.Generic;

namespace E08.TrafficJam
{
    internal class TrafficJam
    {
        static void Main(string[] args)
        {
            int carsAlowedToPass = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int carsPassed = 0;

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    while (cars.Count > 0)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        carsPassed++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }

            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}