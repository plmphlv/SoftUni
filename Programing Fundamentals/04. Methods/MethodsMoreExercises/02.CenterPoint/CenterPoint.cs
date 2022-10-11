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

            double[] centerPoint = CenterPointFinder(points);
            Console.WriteLine($"({String.Join(", ", centerPoint)})");

        }

        static double[] CenterPointFinder(double[] points)
        {
            double[] centerPoints = new double[2];


            if (Math.Abs(points[0]) == Math.Abs(points[2]) && Math.Abs(points[1]) == Math.Abs(points[3]))
            {
                centerPoints[0] = points[0];
                centerPoints[1] = points[1];
            }
            else if ((Math.Abs(points[0]) < Math.Abs(points[2])) && (Math.Abs(points[1]) < Math.Abs(points[3])))
            {
                centerPoints[0] = points[0];
                centerPoints[1] = points[1];
            }
            else if ((Math.Abs(points[0]) <= Math.Abs(points[2])) || (Math.Abs(points[1]) <= Math.Abs(points[3])))
            {
                centerPoints[0] = points[0];
                centerPoints[1] = points[1];
            }
            else
            {
                centerPoints[0] = points[2];
                centerPoints[1] = points[3];
            }

            Math.Max(centerPoints[0], centerPoints[1]);
            return centerPoints;
        }
    }
}