using System;

namespace _12.RefactorSpecialNumbers
{
    internal class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int currentNum = 1; currentNum <= endNumber; currentNum++)
            {
                int numCopy = currentNum;
                int sum = 0;

                while (numCopy > 0)
                {
                    sum += numCopy % 10;
                    numCopy = numCopy / 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNum, isSpecial);
            }
        }
    }
}