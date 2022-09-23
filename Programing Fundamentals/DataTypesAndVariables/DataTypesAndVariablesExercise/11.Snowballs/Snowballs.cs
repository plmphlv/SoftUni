using System;

namespace _11.Snowballs
{
    internal class Snowballs
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());

            double bestSnowballValue = 0;
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;

            for (int i = 1; i <= numOfInputs; i++)
            {
                double snowballSnow = double.Parse(Console.ReadLine());
                double snowballTime = double.Parse(Console.ReadLine());
                double snowballQuality = double.Parse(Console.ReadLine());

                double snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballValue = Math.Ceiling(snowballValue);
                    bestSnowballQuality = (int)snowballQuality;
                    bestSnowballSnow = (int)snowballSnow;
                    bestSnowballTime = (int)snowballTime;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");
        }
    }
}