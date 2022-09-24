using System;

namespace _4.RepairCode
{
    internal class RefactoringPrimeChecker
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 2; number <= n; number++)
            {
                bool isPrime = true;

                for (int diveder = 2; diveder < number; diveder++)
                {
                    if (number % diveder == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("{0} -> true", number);
                }
                else
                {
                    Console.WriteLine("{0} -> false", number);
                }
            }
        }
    }
}