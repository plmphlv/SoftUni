using System;

namespace MultiplyBy2
{
    internal class MultiplyBy2
    {
        static void Main(string[] args)
        {
            double num = 0;
            while (num >= 0)
            {
                num = double.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    num *= 2;
                    Console.WriteLine($"Result: {num:f2}");
                }
                else
                    Console.WriteLine("Negative number!");
            }
        }
    }
}
