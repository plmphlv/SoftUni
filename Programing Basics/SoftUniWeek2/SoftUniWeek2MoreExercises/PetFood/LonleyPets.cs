using System;

namespace PetFood
{
    internal class LonleyPets
    {
        static void Main(string[] args)
        {
            int absentDays = int.Parse(Console.ReadLine());
            double totalPetFood = double.Parse(Console.ReadLine());        // in kilos
            double dogFoodPerDay = double.Parse(Console.ReadLine());      // in kilos
            double catFoodPerDay = double.Parse(Console.ReadLine());     // in kilos
            double turtleFoodPerDay = double.Parse(Console.ReadLine()); // in kilos

            double petFoorRequired = (absentDays * dogFoodPerDay) + (absentDays * catFoodPerDay) + ((absentDays * turtleFoodPerDay) / 1000);

            if (petFoorRequired <= totalPetFood)
            {
                totalPetFood = Math.Floor(totalPetFood - petFoorRequired);
                Console.WriteLine($"{totalPetFood} kilos of food left.");
            }
            else
            {
                petFoorRequired = Math.Ceiling(petFoorRequired - totalPetFood);
                Console.WriteLine($"{petFoorRequired} more kilos of food are needed.");
            }
        }
    }
}
