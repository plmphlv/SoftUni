using System;

namespace AquariumFill
{
    class CalculateWater
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double sandOcupation = double.Parse(Console.ReadLine()) / 100;
            double aquariumWater = ((lenght * width * height) * 0.001) * (1 - sandOcupation);

            Console.WriteLine(aquariumWater);
        }
    }
}
