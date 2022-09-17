using System;

namespace SumOfOddNumbers
{
    internal class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int odd = 2 * i - 1;
                Console.WriteLine(odd);
                sum += odd;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}