using System;

namespace CinemaTickets
{
    internal class CinemaTickets
    {
        static void Main(string[] args)
        {
            string moovieComand;
            int kidsTickets = 0;
            int studentsTickets = 0;
            int standatrtTickets = 0;
            int totalTickets = 0;

            while((moovieComand = Console.ReadLine()) != "Finish")
            {
                int seats=int.Parse(Console.ReadLine());
                string ticketType;
                int seatsTaken = 0;
         

                while ((ticketType = Console.ReadLine())!="End")
                {

                    switch (ticketType)
                    {
                        case "standard":
                            standatrtTickets++;
                            totalTickets++;
                            seatsTaken++;
                            break;
                        case "student":
                            studentsTickets ++;
                            totalTickets++;
                            seatsTaken++;

                            break ;
                        case "kid":
                            kidsTickets ++;
                            totalTickets++;
                            seatsTaken++;
                            break;
                            default:
                            break ;
                    }

                    if (seatsTaken >= seats)
                    {
                        break;
                    }
                }
                double atendace = ((double)seatsTaken / (double)seats)*100;
                Console.WriteLine($"{moovieComand} - {atendace:f2}% full.");
            }
            double studentAtendace = ((double)studentsTickets / (double)totalTickets) * 100;
            double standartAtendace = ((double)standatrtTickets / (double)totalTickets) * 100;
            double kidsAtendace = ((double)kidsTickets / (double)totalTickets) * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentAtendace:f2}% student tickets.");
            Console.WriteLine($"{standartAtendace:f2}% standard tickets.");
            Console.WriteLine($"{kidsAtendace:f2}% kids tickets.");
        }
    }
}
