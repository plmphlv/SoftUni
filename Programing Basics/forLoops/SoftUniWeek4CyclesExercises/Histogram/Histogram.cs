using System;

namespace Histogram
{
    internal class Histogram
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 1; i <= numberOfInputs; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                    p1++;
                else if (num >= 200 && num <= 399)
                    p2++;
                else if (num >= 400 && num <= 599)
                    p3++;
                else if (num >= 600 && num <= 799)
                    p4++;
                else if (num >= 800)
                    p5++;
            }

            double percent1 = ((double)p1 / (double)numberOfInputs)*100;
            double percent2 = ((double)p2 / (double)numberOfInputs)*100;
            double percent3 = ((double)p3 / (double)numberOfInputs)*100;
            double percent4 = ((double)p4 / (double)numberOfInputs)*100;
            double percent5 = ((double)p5 / (double)numberOfInputs)*100;

            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
            Console.WriteLine($"{percent4:f2}%");
            Console.WriteLine($"{percent5:f2}%");
        }
    }
}
