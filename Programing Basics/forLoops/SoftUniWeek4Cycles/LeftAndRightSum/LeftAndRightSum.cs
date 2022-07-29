using System;

namespace LeftAndRightSum
{
    internal class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int nimOfinputs = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= 2 * nimOfinputs; i++)
            {
                int inputNums = int.Parse(Console.ReadLine());

                if (i <=nimOfinputs)
                {
                    rightSum += inputNums;
                }
                else
                {
                    leftSum += inputNums;
                }
            }
            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
