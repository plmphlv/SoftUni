using System;

namespace Travelling
{
    internal class Travelling
    {
        static void Main(string[] args)
        {
            string destination;

            while ((destination = Console.ReadLine()) != "End")
            {
                double minSumReq = double.Parse(Console.ReadLine());
                double savings = 0;
                while (savings < minSumReq)
                {
                    double addFunds = double.Parse(Console.ReadLine());
                    savings += addFunds;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}