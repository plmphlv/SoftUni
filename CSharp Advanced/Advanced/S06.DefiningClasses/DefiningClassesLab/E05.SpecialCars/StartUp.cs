using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace CarManufacturer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string command = String.Empty;



            List<Tire[]> tiresList = new List<Tire[]>();

            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] tireArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);


                Tire[] tireSet = new Tire[4]
                {
                new Tire(int.Parse(tireArgs[0]),double.Parse( tireArgs[1])),
                new Tire(int.Parse(tireArgs[2]),double.Parse( tireArgs[3])),
                new Tire(int.Parse(tireArgs[4]),double.Parse( tireArgs[5])),
                new Tire(int.Parse(tireArgs[6]),double.Parse( tireArgs[7])),
                };

                tiresList.Add(tireSet);

            }



            List<Engine> engineList = new List<Engine>();

            while ((command = Console.ReadLine()) != "Engines done")
            {
                string[] engineArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(int.Parse(engineArgs[0]), double.Parse(engineArgs[1]));

                engineList.Add(engine);
            }




            List<Car> carList = new List<Car>();

            while ((command = Console.ReadLine()) != "Show special")
            {
                string[] carArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string make = carArgs[0];
                string model = carArgs[1];
                int year = int.Parse(carArgs[2]);
                double fuelQty = double.Parse(carArgs[3]);
                double fuelConsumption = double.Parse(carArgs[4]);
                int engineIndex = int.Parse(carArgs[5]);
                int tireIndex = int.Parse(carArgs[6]);

                if (engineIndex >= 0 && engineIndex < engineList.Count)
                {
                    if (tireIndex >= 0 && tireIndex < tiresList.Count)
                    {
                        Engine engineForCar = engineList[tireIndex];
                        Tire[] tireSet = tiresList[tireIndex];
                        Car car = new Car(make, model, year, fuelQty, fuelConsumption, engineForCar, tireSet);

                        carList.Add(car);
                    }
                }
            }


            Func<Car, bool> tirePresure = cr =>
            {

                double sum = 0;

                foreach (Tire ti in cr.Tires)
                {
                    sum += ti.Pressure;
                }

                return cr.Engine.HorsePower > 330 && cr.Year >= 2017 && sum >= 9 && sum <= 10;
            };

            carList = carList.Where(tirePresure).ToList();

            foreach (Car car in carList)
            {
                car.Drive(20);

                StringBuilder carSpecs = new StringBuilder();
                carSpecs.AppendLine($"Make: {car.Make}");
                carSpecs.AppendLine($"Model: {car.Model}");
                carSpecs.AppendLine($"Year: {car.Year}");
                carSpecs.AppendLine($"HorsePowers: {car.Engine.HorsePower}");
                carSpecs.AppendLine($"FuelQuantity: {car.FuelQuantity}");

                Console.WriteLine(carSpecs.ToString().Trim());
            }
        }
    }
}