using System;

namespace MinNumber
{
    internal class MinNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;

            while (input != "Stop")
            {
                int value = int.Parse(input);
                if (value < min)
                    min = value;
                input = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
