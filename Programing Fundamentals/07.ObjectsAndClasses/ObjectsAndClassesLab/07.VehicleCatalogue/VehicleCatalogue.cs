using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    internal class VehicleCatalogue
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {

                AddVehicleToCatalog(ref catalog, command);

            }

            PrintCatalog(catalog);

        }

        private static void AddVehicleToCatalog(ref Catalog catalog, string command)
        {
            string[] cmdArgs = command.Split("/", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string vehicleType = cmdArgs[0];
            string vehicleBrand = cmdArgs[1];
            string vehicleModel = cmdArgs[2];
            int vehicleProperty = int.Parse(cmdArgs[3]);

            switch (vehicleType)
            {
                case "Car":

                    Car car = new Car(vehicleBrand, vehicleModel, vehicleProperty);
                    catalog.Cars.Add(car);

                    break;
                case "Truck":

                    Truck truck = new Truck(vehicleBrand, vehicleModel, vehicleProperty);
                    catalog.Trucks.Add(truck);

                    break;

            }
        }

        public static void PrintCatalog(Catalog catalog)
        {
            if (catalog.Cars.Count > 0)
            {

                Console.WriteLine("Cars:");
                foreach (var car in catalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.Horsepower}hp");
                }

            }

            if (catalog.Trucks.Count > 0)
            {

                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }

            }
        }
    }

    class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

    }

    class Car
    {
        public Car(string brand, string model, int horsepower)
        {

            Brand = brand;
            Model = model;
            Horsepower = horsepower;

        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Horsepower { get; set; }

    }

    class Truck
    {
        public Truck(string brand, string model, int weight)
        {

            Brand = brand;
            Model = model;
            Weight = weight;

        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }

}