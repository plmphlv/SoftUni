using System;

namespace PaintingTheHouse
{
    class PaintingPrice
    {
        static void Main(string[] args)
        {
            int covers = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double matterialsCost = ((covers+2)*1.50) + ((paint+(paint*0.1)) * 14.50) + (thinner *5.00) + 0.40;
            double totalCost = (matterialsCost * 0.3) * 8 + matterialsCost;
            Console.WriteLine(totalCost);
        }
    }
}
