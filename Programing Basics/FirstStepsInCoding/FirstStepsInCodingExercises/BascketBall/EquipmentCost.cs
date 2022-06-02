using System;

namespace BascketBall
{
    class EquipmentCost
    {
        static void Main(string[] args)
        {
            int trainingCost = int.Parse(Console.ReadLine());
            double trainersCost = trainingCost - (trainingCost * 0.40);
            double uniformCost = trainersCost - (trainersCost * 0.20);
            double ballCost = uniformCost * 0.25;
            double accessoriesCost = ballCost * 0.20;
            double totaCost = trainingCost + trainersCost + uniformCost + ballCost + accessoriesCost; 

            Console.WriteLine(totaCost);
        }
    }
}
