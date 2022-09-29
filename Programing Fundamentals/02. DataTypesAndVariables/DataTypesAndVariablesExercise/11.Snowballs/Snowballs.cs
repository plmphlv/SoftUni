using System;
using System.Numerics;

namespace _11.Snowballs
{
    internal class Snowballs
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());

            BigInteger bestSnowballValue = BigInteger.MinusOne;
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;

            for (int i = 1; i <= numOfInputs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballValue = snowballValue;
                    bestSnowballQuality = snowballQuality;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");
        }
    }
}