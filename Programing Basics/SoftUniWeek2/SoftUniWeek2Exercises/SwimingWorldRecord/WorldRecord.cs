using System;

namespace SwimingWorldRecord
{
    internal class WorldRecord
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double estimatedTime = distance * timeForOneMeter;
            double slowdownTime = Math.Floor((distance / 15)) * 12.5;
            double bestTime = estimatedTime + slowdownTime;

            if (bestTime<recordTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {bestTime:f2} seconds.");
            }
            else
            {
                bestTime -= recordTime;
                Console.WriteLine($"No, he failed! He was {bestTime:f2} seconds slower.");
            }
        }
    }
}
