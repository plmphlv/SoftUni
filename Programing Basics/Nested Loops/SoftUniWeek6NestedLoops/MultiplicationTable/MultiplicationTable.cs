using System;

namespace MultiplicationTable
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int r = i * j;
                    Console.WriteLine($"{i} * {j} = {r}");
                }
            }
        }
    }
}