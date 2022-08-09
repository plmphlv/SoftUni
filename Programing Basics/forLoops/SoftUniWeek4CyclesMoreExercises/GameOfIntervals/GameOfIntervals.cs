using System;

namespace GameOfIntervals
{
    internal class GameOfIntervals
    {
        static void Main(string[] args)
        {
            int turnCount = int.Parse(Console.ReadLine());

            double scoreboard = 0;

            int lineOne = 0;
            int lineTwo = 0;
            int lineThree = 0;
            int lineFour = 0;
            int lineFive = 0;
            int lineInvalid = 0;

            for (int i = 1; i <= turnCount; i++)
            {
                int score = int.Parse(Console.ReadLine());

                if (score >= 0 && score <= 9)
                {
                    scoreboard += (double)score * 0.2;
                    lineOne++;
                }
                else if (score >= 10 && score <= 19)
                {
                    scoreboard += (double)score * 0.3;
                    lineTwo++;
                }
                else if (score >= 20 && score <= 29)
                {
                    scoreboard += (double)score * 0.4;
                    lineThree++;
                }
                else if (score >= 30 && score <= 39)
                {
                    scoreboard += 50;
                    lineFour++;
                }
                else if (score >= 40 && score <= 50)
                {
                    scoreboard += 100;
                    lineFive++;
                }
                else if (score <= 0 || score > 50)
                {
                    scoreboard /= 2;
                    lineInvalid++;
                }
            }

            double lineOnePercent = (double)lineOne / (double)turnCount * 100;
            double lineTwoPercent = (double)lineTwo / (double)turnCount * 100;
            double lineThreePercent = (double)lineThree / (double)turnCount * 100;
            double lineFourPercent = (double)lineFour / (double)turnCount * 100;
            double lineFivePercent = (double)lineFive / (double)turnCount * 100;
            double lineInvalidPercent = (double)lineInvalid / (double)turnCount * 100;

            Console.WriteLine($"{scoreboard:f2}");
            Console.WriteLine($"From 0 to 9: {lineOnePercent:f2}%");
            Console.WriteLine($"From 10 to 19: {lineTwoPercent:f2}%");
            Console.WriteLine($"From 20 to 29: {lineThreePercent:f2}%");
            Console.WriteLine($"From 30 to 39: {lineFourPercent:f2}%");
            Console.WriteLine($"From 40 to 50: {lineFivePercent:f2}%");
            Console.WriteLine($"Invalid numbers: {lineInvalidPercent:f2}%");
        }
    }
}
