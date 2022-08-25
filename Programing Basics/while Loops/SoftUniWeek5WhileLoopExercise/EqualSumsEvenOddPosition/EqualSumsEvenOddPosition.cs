using System;

namespace EqualSumsEvenOddPosition
{
    internal class EqualSumsEvenOddPosition
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int finalNum = int.Parse(Console.ReadLine());

            for (int currNum = firstNum; currNum <= finalNum; currNum++)
            {
                int current = currNum;
                int digitPos = 6;
                int equalSum = 0;
                int oddSum = 0;
                while (current > 0)
                {
                    int digit = current % 10;
                    current=current / 10;

                    if (digitPos % 2 == 0)
                    {
                        equalSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                    digitPos--;
                }
                if (oddSum == equalSum)
                {
                    Console.Write(currNum + " ");
                }
            }
        }
    }
}
