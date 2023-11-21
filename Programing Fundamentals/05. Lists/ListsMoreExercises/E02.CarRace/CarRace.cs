using System;
using System.Linq;

namespace E02.CarRace
{
    internal class CarRace
    {
        static void Main(string[] args)
        {

            double[] times = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            double leftTime = 0;
            double rightTime = 0;

            int midleIndex = (times.Length - 1) / 2;

            for (int i = 0; i < midleIndex; i++)
            {
                if (times[i] > 0)
                {
                    leftTime += times[i];
                }
                else
                {
                    leftTime *= 0.8;
                }
            }

            for (int i = times.Length-1; i > midleIndex; i--)
            {
                    if (times[i] > 0)
                    {
                        rightTime += times[i];
                    }
                    else
                    {
                        rightTime *= 0.8;
                    }
            }

            string winingSide = (leftTime < rightTime) ? "left" : "right";
            double winingTime = (leftTime < rightTime) ? leftTime : rightTime;

            Console.WriteLine($"The winner is {winingSide} with total time: {winingTime}");

        }
    }
}