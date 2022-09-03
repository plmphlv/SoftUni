using System;

namespace SumOfTwoNumbers
{
    internal class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int intervalBeginning = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int magicNumberLock = 0;
            int comboCount = 0;
            bool found = false;
            int storeI = 0;
            int storeJ = 0;

            for (int i = intervalBeginning; i <= intervalEnd; i++)
            {
                for (int j = intervalBeginning; j <= intervalEnd; j++)
                {
                    int sum = i + j;
                    comboCount++;
                    if (sum == magicNumber && !found)
                    {
                        storeI = i;
                        storeJ = j;
                        magicNumberLock = comboCount;
                        found = true;
                    }
                }
            }

            if (found)
                Console.WriteLine($"Combination N:{magicNumberLock} ({storeI} + {storeJ} = {magicNumber})");
            else
                Console.WriteLine($"{comboCount} combinations - neither equals {magicNumber}");
        }
    }
}