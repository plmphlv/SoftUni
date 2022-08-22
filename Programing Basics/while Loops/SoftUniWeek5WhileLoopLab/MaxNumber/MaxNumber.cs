using System;

namespace MaxNumber
{
    internal class MaxNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;

            while(input != "Stop")
            {
                int value=int.Parse(input);
                if(value > max)
                    max = value;
                input = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
