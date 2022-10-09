using System;

namespace _10.TopNumber
{
    internal class TopNumber
    {
        static void Main(string[] args)
        {
            TopFinderMethod(int.Parse(Console.ReadLine()));
        }

        static void TopFinderMethod(int endNumber)
        {
            for (int i = 1; i < endNumber; i++)
            {
                bool sumOfDigitsEquals8 = SumOfDigitsFinder(i);
                bool hasAtLeastOneOddDigit = OddDigitFinder(i);

                if (sumOfDigitsEquals8 && hasAtLeastOneOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool OddDigitFinder(int i)
        {
            while (i > 0)
            {
                int digit = i % 10;
                i /= 10;
                if (!(digit % 2 == 0))
                {
                    return true;
                }
            }
            return false;
        }

        static bool SumOfDigitsFinder(int i)
        {
            int sumOfDigits = 0;

            while (i > 0)
            {
                sumOfDigits += i % 10;
                i /= 10;
            }
            return (sumOfDigits % 8 == 0) ? true : false;
        }
    }
}