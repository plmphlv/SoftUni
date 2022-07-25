using System;

namespace MatchTickets
{
    internal class MatchTickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketsType = Console.ReadLine();
            int groupMembers = int.Parse(Console.ReadLine());

            double ticketsCost = 0;
            double transportCost = 0;

            if (ticketsType == "VIP")
            {
                ticketsCost = groupMembers * 499.99;
            }
            else if (ticketsType == "Normal")
            {
                ticketsCost = groupMembers * 249.99;
            }

            if (groupMembers >= 1 && groupMembers <= 4)
            {
                transportCost = budget * 0.75;
            }
            else if (groupMembers >= 5 && groupMembers <= 9)
            {
                transportCost = budget * 0.6;
            }
            else if(groupMembers >= 10 && groupMembers <= 24)
            {
                transportCost = budget * 0.5;
            }
            else if (groupMembers >= 25 && groupMembers <= 49)
            {
                transportCost = budget * 0.4;
            }
            else if (groupMembers >= 50)
            {
                transportCost = budget * 0.25;
            }

             double totalCost = transportCost + ticketsCost;

            if (budget >= totalCost)
            {
                Console.WriteLine($"Yes! You have {budget - totalCost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCost - budget:f2} leva.");
            }
        }
    }
}
