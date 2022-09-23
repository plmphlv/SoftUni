using System.Collections.Generic;

namespace _2.FromLeftToTheRight
{
    internal class FromLeftToTheRight
    {
        static void Main(string[] args)
        {

            int reads = int.Parse(Console.ReadLine());

            for (int i = 1; i <= reads; i++)
            {
                string leftRight = Console.ReadLine();
                string[] split = leftRight.Split(' ');
                long[] nums = new long[split.Length];
                int arrPosition = 0;

                foreach (string line in split)
                {
                    nums[arrPosition++] = long.Parse(line);
                }

                long biggest = nums.Max();
                long digitSum = 0;

                while (biggest > 0)
                {
                    digitSum += biggest % 10;
                    biggest /= 10;
                }

                Console.WriteLine(digitSum);
            }
        }
    }
}