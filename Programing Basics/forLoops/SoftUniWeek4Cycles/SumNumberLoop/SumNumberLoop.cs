using System;

namespace SumNumberLoop
{
    internal class SumNumberLoop
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= inputCount; i++)
            {
                int numInput = int.Parse(Console.ReadLine());
                sum += numInput;

            }
            Console.WriteLine(sum);
        }
    }
}
