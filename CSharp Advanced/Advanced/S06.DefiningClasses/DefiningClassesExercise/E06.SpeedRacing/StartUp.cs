using DefiningClasses;
using System;
using System.Collections.Generic;

namespace E06.SpeedRacing
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            string command;
            string[] cmdArgs;

            for (int i = 0; i < loops; i++)
            {
                command = Console.ReadLine();
                cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(cmdArgs[0], double.Parse(cmdArgs[1]), double.Parse(cmdArgs[2]));

                cars.Add(car.Model, car);
            }

            while ((command = Console.ReadLine()) != "End")
            {
                cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Car car = cars[cmdArgs[1]];
                car.Drive(double.Parse(cmdArgs[2]));
            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelConsumptionPerKm:f2} {car.TraveledDistance}");
            }
        }
    }
}