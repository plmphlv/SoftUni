using System;

namespace FuelTankPart1
{
    internal class GasGasGas
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelInLiters = double.Parse(Console.ReadLine());

            if (fuelType == "Gasoline" || fuelType == "gasoline")
            {
                if (fuelInLiters>=25)
                {
                    Console.WriteLine("You have enough gasoline.");
                }
                else if (fuelInLiters < 25)
                {
                    Console.WriteLine("Fill your tank with gasoline!");
                }
            }
            else if (fuelType == "Diesel" || fuelType == "diesel")
            {
                if (fuelInLiters >= 25)
                {
                    Console.WriteLine("You have enough diesel.");
                }
                else if (fuelInLiters < 25)
                {
                    Console.WriteLine("Fill your tank with diesel!");
                }
            }
            else if (fuelType == "Gas" || fuelType == "gas")
            {
                if (fuelInLiters >= 25)
                {
                    Console.WriteLine("You have enough gas.");
                }
                else if (fuelInLiters < 25)
                {
                    Console.WriteLine("Fill your tank with gas!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
