using System;

namespace _02.CenterPoint
{
    internal class CenterPoint
    {
        static void Main(string[] args)
        {
            double[] points = new double[4];

            for (int i = 0; i < 4; i++)
            {
                points[i] = double.Parse(Console.ReadLine());
            }

            CenterPointFinder(points);
        }

        static void CenterPointFinder(double[] points)
        {
            double first = Math.Sqrt(Math.Pow(points[1], 2) + Math.Pow(points[0], 2));
            double secound = Math.Sqrt(Math.Pow(points[2], 2) + Math.Pow(points[3], 2));

            if (first < secound)
            {
                Console.WriteLine($"({points[0]}, {points[1]})");
            }
            else
            {
                Console.WriteLine($"({points[2]}, {points[3]})");
            }
        }
    }
}