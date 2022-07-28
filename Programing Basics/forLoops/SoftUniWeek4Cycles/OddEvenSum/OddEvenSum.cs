using System;

namespace OddEvenSum
{
    internal class OddEvenSum
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int counter = 1; counter <= numberOfInputs; counter++)
            {
                int numInput = int.Parse(Console.ReadLine());

                if (counter % 2 == 0)
                {
                    evenSum += numInput;
                }
                else
                {
                    oddSum += numInput;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}
