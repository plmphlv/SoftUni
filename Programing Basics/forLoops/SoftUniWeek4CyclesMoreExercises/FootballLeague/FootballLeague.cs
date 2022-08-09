using System;

namespace FootballLeague
{
    internal class FootballLeague
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fanCount = int.Parse(Console.ReadLine());

            int sectionA = 0;
            int sectionB = 0;
            int sectionV = 0;
            int sectionG = 0;

            for (int i = 1; i <= fanCount; i++)
            {
                char section = char.Parse(Console.ReadLine());

                if (section == 'A')
                    sectionA++;
                else if (section == 'B')
                    sectionB++;
                else if (section == 'V')
                    sectionV++;
                else if (section == 'G')
                    sectionG++;
            }

            double sectionAPercentage = ((double)sectionA / (double)fanCount) * 100;
            double sectionBPercentage = ((double)sectionB / (double)fanCount) * 100;
            double sectionVPercentage = ((double)sectionV / (double)fanCount) * 100;
            double sectionGPercentage = ((double)sectionG / (double)fanCount) * 100;
            double fanPercentage = ((double)fanCount / stadiumCapacity) * 100;

            Console.WriteLine($"{sectionAPercentage:f2}%");
            Console.WriteLine($"{sectionBPercentage:f2}%");
            Console.WriteLine($"{sectionVPercentage:f2}%");
            Console.WriteLine($"{sectionGPercentage:f2}%");
            Console.WriteLine($"{fanPercentage:f2}%");
        }
    }
}
