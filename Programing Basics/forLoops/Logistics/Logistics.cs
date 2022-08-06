using System;

namespace Logistics
{
    internal class Logistics
    {
        static void Main(string[] args)
        {
            int numOfDeliverys = int.Parse(Console.ReadLine());

            double weightTotal = 0;


            double busWeight=0;
            double truckWeight = 0;
            double trainWeight=0;

            for(int done=1; done<=numOfDeliverys; done++)
            {
                int weight = int.Parse(Console.ReadLine());

                if (weight <=3)
                {
                    busWeight += weight;
                }
                else if (weight >= 0 && weight <=11)
                {
                    truckWeight+=weight;
                }
                else if (weight>=12)
                {
                    trainWeight+=weight;
                }

                weightTotal+=weight;
            }

            double averageCost = (double)(busWeight * 200 + truckWeight * 175 + trainWeight * 120) / weightTotal;

            double busPercent = (busWeight / weightTotal) * 100;
            double truckPercent = (truckWeight / weightTotal) * 100;
            double trainPercent = (trainWeight / weightTotal) * 100;

            Console.WriteLine($"{averageCost:f2}");
            Console.WriteLine($"{busPercent:f2}%");
            Console.WriteLine($"{truckPercent:f2}%");
            Console.WriteLine($"{trainPercent:f2}%");
        }
    }
}
