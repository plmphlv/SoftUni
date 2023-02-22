using E07.RawData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses;

internal class StartUp
{
    static void Main(string[] args)
    {
        int loops = int.Parse(Console.ReadLine());

        List<Car> list = new List<Car>();

        for (int i = 0; i < loops; i++)
        {
            string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string modelCar = cmdArgs[0];

            Engine engine = new Engine(int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));

            Cargo cargo = new Cargo(cmdArgs[4], double.Parse(cmdArgs[3]));

            Tires[] tires = new Tires[]
            {
                new Tires(double.Parse(cmdArgs[5]),int.Parse(cmdArgs[6])),
                new Tires(double.Parse(cmdArgs[7]),int.Parse(cmdArgs[8])),
                new Tires(double.Parse(cmdArgs[9]),int.Parse(cmdArgs[10])),
                new Tires(double.Parse(cmdArgs[11]),int.Parse(cmdArgs[12]))
            };

            Car car = new Car(modelCar, engine, cargo, tires);

            list.Add(car);
        }

        string cargoType = Console.ReadLine();

        if (cargoType == "fragile")
        {
            list = list.Where(x => x.Cargo.TypeOfCargo == cargoType && x.Tires.Any(t => t.Pressure < 1)).ToList();
        }
        else if (cargoType == "flammable")
        {
            list = list.Where(x => x.Cargo.TypeOfCargo == cargoType && x.Engine.Power > 250).ToList();
        }



        Console.WriteLine(String.Join(Environment.NewLine, list.Select(x => $"{x.Model}")));

    }
}