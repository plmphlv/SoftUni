using System;

namespace _10.MultiplyEvensByOdds
{
    internal class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            int sum = GetMultipleOfEvenAndOdds(input);
            Console.WriteLine(sum);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int sumOfOdds = GetSumOfOddDigits(number);
            int sumOfEvens = GetSumOfEvenDigits(number);

            return sumOfEvens * sumOfOdds;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }
            }

            return oddSum;
        }
    }
}