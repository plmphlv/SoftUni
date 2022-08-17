using System;

namespace SumNumbers
{
    internal class SumNumbers
    {
        static void Main(string[] args)
        {
            int target=int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < target)
            {
                sum+=int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
