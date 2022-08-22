using System;

namespace AccountBalance
{
    internal class AccountBalance
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double kinti = 0;
            while (input != "NoMoreMoney")
            {
                double moneny=double.Parse(input);
                if (moneny<0)
                {
                    Console.WriteLine($"Invalid operation!");
                    Console.WriteLine($"Total: {kinti:f2}");
                    return;
                }
                kinti += moneny;
                Console.WriteLine($"Increase: {moneny:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {kinti:f2}");
        }
    }
}
