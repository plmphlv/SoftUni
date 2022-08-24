using System;

namespace SumPrimeNonPrime
{
    internal class SumPrimeNonPrime
    {
        static void Main(string[] args)
        {
            int primeSumm = 0;
            int nonPrimeSum = 0;
            string command;
            while ((command = Console.ReadLine()) != "stop")
            {
                int num = int.Parse(command);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                else if (num == 0)
                {
                    nonPrimeSum += num;
                    continue;
                }

                bool isPrime = true;
                for (int div = 2; div < num; div++)
                {
                    if (num % div == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeSumm += num;
                }
                else
                {
                    nonPrimeSum += num;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSumm}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
