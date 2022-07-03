using System;

namespace PipesInAPool
{
    internal class PoolFlood
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int pipeOnePerHour = int.Parse(Console.ReadLine());
            int pipeTwoPerHour = int.Parse(Console.ReadLine());
            double hoursAbsent = double.Parse(Console.ReadLine());

            double pipeOneOutput = pipeOnePerHour * hoursAbsent;
            double pipeTwoOutput = pipeTwoPerHour * hoursAbsent;
            double currentVolume = pipeOneOutput + pipeTwoOutput;

           
            if (currentVolume > poolVolume)
            {
                double extraVolume = currentVolume - poolVolume;
                Console.WriteLine($"For {hoursAbsent:f2} hours the pool overflows with {extraVolume:f2}");
            }
            else
            {
                double volumeLeft = (currentVolume / poolVolume) * 100;
                pipeOneOutput = (pipeOneOutput / currentVolume) * 100;
                pipeTwoOutput = (pipeTwoOutput / currentVolume) * 100;
                Console.WriteLine($"The pool is {volumeLeft}% full. Pipe 1: {pipeOneOutput:f2}%. Pipe 2: {pipeTwoOutput:f2}%.");
            }
        }
    }
}
