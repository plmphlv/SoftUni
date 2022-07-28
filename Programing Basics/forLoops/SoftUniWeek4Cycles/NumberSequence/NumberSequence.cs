using System;

namespace NumberSequence
{
    internal class NumberSequence
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;

            for (int i = 1; i <= count; i++)
            {
                int numer=int.Parse(Console.ReadLine());

                if (numer <minValue)
                {
                    minValue = numer;
                }
                if (numer > maxValue)
                {
                    maxValue = numer;
                }
            }

            Console.WriteLine($"Max number: {maxValue}");
            Console.WriteLine($"Min number: {minValue}");
        }
    }
}
