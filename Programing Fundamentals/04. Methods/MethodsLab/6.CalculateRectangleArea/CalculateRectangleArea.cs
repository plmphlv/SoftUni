using System;

namespace _6.CalculateRectangleArea
{
    internal class CalculateRectangleArea
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = RectangleArea(a, b);
            Console.WriteLine(area);
        }

        static double RectangleArea(double width, double heigh)
        {
            return width * heigh;
        }
    }
}