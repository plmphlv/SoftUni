using System;

namespace _01.GuineaPig
{
    internal class GuineaPig
    {
        static void Main(string[] args)
        {
            decimal foodQuantity = decimal.Parse(Console.ReadLine());
            decimal hayKilos = decimal.Parse(Console.ReadLine());
            decimal coverKilos = decimal.Parse(Console.ReadLine());
            decimal guneaPigWeight = decimal.Parse(Console.ReadLine());

            bool isEnough = true;

            for (int i = 1; i <= 30; i++)
            {

                foodQuantity -= 0.300m;

                if (i % 2 == 0)
                {
                    hayKilos -= foodQuantity * 0.05m;
                }

                if (i % 3 == 0)
                {
                    coverKilos -= guneaPigWeight / 3m;
                }

                if (foodQuantity <= 0 || hayKilos <= 0 || coverKilos <= 0)
                {
                    isEnough = false;
                    break;
                }

            }

            if (isEnough)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodQuantity:f2}, Hay: {hayKilos:f2}, Cover: {coverKilos:f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}