using System;

namespace Cinema
{
    internal class Cinema
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double income = 0;

            income = rows * columns;

            if (projection == "Premiere")
            {
                income = rows * columns * 12;
            }
            else if (projection == "Normal")
            {
                income = rows * columns * 7.50;
            }
            else if (projection == "Discount")
            {
                income = rows * columns * 5;
            }

            Console.WriteLine($"{income:f2}");
        }
    }
}
