using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.EvenTimes
{
    internal class EvenTimes
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            Dictionary<int, int> nums = new Dictionary<int, int>();

            for (int i = 0; i < loops; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!nums.ContainsKey(num))
                {
                    nums[num] = 0;
                }

                nums[num]++;
            }

            KeyValuePair<int, int> evenNum = nums.OrderByDescending(x => x.Value % 2 == 0).First();

            Console.WriteLine(evenNum.Key);
        }
    }
}