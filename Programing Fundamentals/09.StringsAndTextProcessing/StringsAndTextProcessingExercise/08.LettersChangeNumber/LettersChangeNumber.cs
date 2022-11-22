using System;

namespace _08.LettersChangeNumber
{
    internal class LettersChangeNumber
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (string s in input)
            {
                char firstLetter = s[0];
                char lastLetter = s[^1];


                string numAsString = s[1..^1];
                double realNum = double.Parse(numAsString);

                if (char.IsUpper(firstLetter))
                {

                    int letterPossition = firstLetter - 64;
                    realNum /= letterPossition;

                }
                else
                {

                    int letterPossition = firstLetter - 96;
                    realNum *= letterPossition;

                }

                if (char.IsUpper(lastLetter))
                {
                    int possitionOfTheLetter = lastLetter - 64;
                    realNum -= possitionOfTheLetter;
                }
                else
                {
                    int possitionOfTheLetter = lastLetter - 96;
                    realNum += possitionOfTheLetter;
                }

                sum += realNum;

            }

            Console.WriteLine($"{sum:f2}");

        }
    }
}