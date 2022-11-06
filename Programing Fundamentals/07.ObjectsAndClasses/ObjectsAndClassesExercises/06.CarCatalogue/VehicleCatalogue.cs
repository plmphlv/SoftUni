using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CarCatalogue
{
    internal class VehicleCatalogue
    {
        static void Main(string[] args)
        {

            ProgramEngine engine = new ProgramEngine();

        }

    }

    class ProgramEngine
    {

        public ProgramEngine()
        {
            Catalogue catalogue = new Catalogue();

            VehicleMaker(catalogue);
            BrowseCatalogue(catalogue);
            CalculateAvarageHoursePower(catalogue);
        }

        public static void CalculateAvarageHoursePower(Catalogue catalogue)
        {
            double carAvgHP = 0;

            if (catalogue.Cars.Count > 0)
            {
                carAvgHP = catalogue.Cars.Average(x => x.VehicleHorsepower);
            }

            double truckAvgHP = 0;

            if (catalogue.Trucks.Count > 0)
            {
                truckAvgHP = catalogue.Trucks.Average(x => x.VehicleHorsepower);
            }

            Console.WriteLine($"Cars have average horsepower of: {carAvgHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAvgHP:f2}.");
        }

        public static void BrowseCatalogue(Catalogue catalogue)
        {
            string printModel;
            while ((printModel = Console.ReadLine()) != "Close the Catalogue")
            {

                Vehicle desiredVehicle = catalogue.Cars.Find(x => x.VehicleModel == printModel);

                if (desiredVehicle == null)
                {
                    desiredVehicle = catalogue.Trucks.Find(x => x.VehicleModel == printModel);
                }

                desiredVehicle.PrintVehicle();
            }
        }

        public static void VehicleMaker(Catalogue catalogue)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string typeOfVehicle = CapitalizeWord(cmdArgs[0]);
                string modelOfVehicle = cmdArgs[1];
                string colourOfVehicle = cmdArgs[2];
                int horsepowerOfVehicle = int.Parse(cmdArgs[3]);

                switch (typeOfVehicle)
                {
                    case "Car":

                        Vehicle car = new Vehicle(typeOfVehicle, modelOfVehicle, colourOfVehicle, horsepowerOfVehicle);
                        catalogue.Cars.Add(car);

                        break;
                    case "Truck":

                        Vehicle truck = new Vehicle(typeOfVehicle, modelOfVehicle, colourOfVehicle, horsepowerOfVehicle);
                        catalogue.Trucks.Add(truck);

                        break;
                }

            }
        }

        public static string CapitalizeWord(string word)
        {
            return String.Concat(char.ToUpper(word[0]), word.Substring(1));
        }

    }

    class Catalogue
    {

        public Catalogue()
        {
            Cars = new List<Vehicle>();
            Trucks = new List<Vehicle>();
        }

        public List<Vehicle> Cars { get; set; }
        public List<Vehicle> Trucks { get; set; }

    }

    class Vehicle
    {
        public Vehicle(string vehicleType, string vehicleModel, string vehicleColour, int vehicleHorsepower)
        {
            VehicleType = vehicleType;
            VehicleModel = vehicleModel;
            VehicleColour = vehicleColour;
            VehicleHorsepower = vehicleHorsepower;
        }

        public string VehicleType { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleColour { get; set; }
        public int VehicleHorsepower { get; set; }

        public void PrintVehicle()
        {

            Console.WriteLine($"Type: {this.VehicleType}\r\n" +
                $"Model: {this.VehicleModel}\r\n" +
                $"Color: {this.VehicleColour}\r\n" +
                $"Horsepower: {this.VehicleHorsepower}");

        }

    }

}