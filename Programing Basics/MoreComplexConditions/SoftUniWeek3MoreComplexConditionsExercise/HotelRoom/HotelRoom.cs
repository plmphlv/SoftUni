using System;

namespace HotelRoom
{
    internal class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double apartment = 0;
            double studio = 0;
            double totalCostStudio = 0;
            double totalCostApartmen = 0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                apartment = 65;
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;
            }
            else if (month == "July" || month == "August")
            {
                studio = 76;
                apartment = 77;
            }

            totalCostStudio = studio * nights;
            totalCostApartmen = apartment * nights;

            if (nights > 14 && (month == "May" || month == "October"))
            {
                totalCostStudio = totalCostStudio - (totalCostStudio * 0.3);
            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                totalCostStudio = totalCostStudio - (totalCostStudio * 0.2);
            }
            else if (nights > 7 && (month == "May" || month == "October"))
            {
                totalCostStudio = totalCostStudio - (totalCostStudio * 0.05);
            }


            if (nights > 14)
            {
                totalCostApartmen = totalCostApartmen - (totalCostApartmen * 0.1);
            }

            Console.WriteLine($"Apartment: {totalCostApartmen:f2} lv.");
            Console.WriteLine($"Studio: {totalCostStudio:f2} lv.");
        }
    }
}
