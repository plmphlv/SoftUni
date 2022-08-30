using System;

namespace NumbersDividedby3WithoutReminder
{
    internal class NumbersDividedby3WithoutReminder
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}