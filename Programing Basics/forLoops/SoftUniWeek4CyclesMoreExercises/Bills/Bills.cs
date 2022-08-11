using System;

namespace Bills
{
    internal class Bills
    {
        static void Main(string[] args)
        {
            int timePeriod = int.Parse(Console.ReadLine());

            double electricityBills = 0;
            double waterBills = 0;
            double internetBills = 0;
            double miscBills = 0;

            for (int i = 1; i <= timePeriod; i++)
            {
                double electricityPrice = double.Parse(Console.ReadLine());

                electricityBills += electricityPrice;
                waterBills += 20;
                internetBills += 15;
                miscBills += (electricityPrice + 20 + 15) + ((electricityPrice + 20 + 15) * 0.2);

            }
            double average = (electricityBills + waterBills + internetBills + miscBills) / timePeriod;

            Console.WriteLine($"Electricity: {electricityBills:f2} lv");
            Console.WriteLine($"Water: {waterBills:f2} lv");
            Console.WriteLine($"Internet: {internetBills:f2} lv");
            Console.WriteLine($"Other: {miscBills:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
