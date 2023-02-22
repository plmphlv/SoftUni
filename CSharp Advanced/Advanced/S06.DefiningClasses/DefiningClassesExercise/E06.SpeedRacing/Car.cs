using System;


namespace DefiningClasses
{
    internal class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKm;
        private double traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            TraveledDistance = 0;
        }

        public string Model { get { return model; } set { model = value; } }
        public double FuelAmount { get { return fuelAmount; } set { fuelAmount = value; } }
        public double FuelConsumptionPerKm { get { return fuelConsumptionPerKm; } set { fuelConsumptionPerKm = value; } }
        public double TraveledDistance { get { return traveledDistance; } set { traveledDistance = value; } }


        public void Drive(double distance)
        {
            if (fuelAmount >= distance * fuelConsumptionPerKm)
            {
                FuelAmount -= distance * fuelConsumptionPerKm;
                TraveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
