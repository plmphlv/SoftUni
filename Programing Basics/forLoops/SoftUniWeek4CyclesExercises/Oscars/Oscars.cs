using System;

namespace Oscars
{
    internal class Oscars
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int numberOfJudjes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfJudjes; i++)
            {
                string judge = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                startingPoints = (judge.Length * points) / 2 + startingPoints;

                // Console.WriteLine($"{startingPoints:f2}");
                if (startingPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {startingPoints:f1}!");
                    return;
                }
            }
            if (startingPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - startingPoints:f1} more!");
            }
        }
    }
}
