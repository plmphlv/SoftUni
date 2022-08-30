using System;

namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfLoops = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= numOfLoops; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"{sum / numOfLoops:f2}");
        }
    }
}