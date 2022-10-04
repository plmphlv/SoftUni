using System;

namespace _1.Train
{
    internal class Train
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numberOfWagons];
            int passengerSum = 0;

            for (int i = 0; i < numberOfWagons; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                passengerSum += wagons[i];
            }

            Console.WriteLine(String.Join(" ", wagons));
            Console.WriteLine(passengerSum);

        }
    }
}