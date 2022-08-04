using System;

namespace HalfSumElement
{
    internal class HalfSumElement
    {
        static void Main(string[] args)
        {
            int numberOfLoops = int.Parse(Console.ReadLine());
            int bigBoy = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= numberOfLoops; i++)
            {
                int nums=int.Parse(Console.ReadLine());

                if (nums > bigBoy)
                {
                    bigBoy = nums;
                }

                sum += nums;
            }

            if ((sum-bigBoy)==bigBoy)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum - bigBoy}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs((sum - bigBoy)-bigBoy)}");
            }
        }
    }
}
