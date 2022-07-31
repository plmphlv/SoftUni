using System;

namespace TennisRanklist
{
    internal class Program
    {
        static void Main()
        {
            int numOfTourneys = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int winRate = 0;
            int totalPoints = 0;

            for (int i = 1; i <= numOfTourneys; i++)
            {
                string tourneyState = Console.ReadLine();

                switch (tourneyState)
                {
                    case "W":
                        totalPoints += 2000;
                        winRate++;
                        break;

                    case "F":
                        totalPoints += 1200;
                        break;

                    case "SF":
                        totalPoints += 720;
                        break;
                }
            }

            double average = Math.Floor((double)totalPoints / (double)numOfTourneys);
            double winPercentage = (double)winRate / (double)numOfTourneys * 100;

            Console.WriteLine($"Final points: {startingPoints + totalPoints}");
            Console.WriteLine($"Average points: {average}");
            Console.WriteLine($"{winPercentage:f2}%");
        }
    }
}