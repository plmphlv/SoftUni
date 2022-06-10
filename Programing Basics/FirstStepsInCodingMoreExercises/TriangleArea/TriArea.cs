using System;

namespace TriangleArea
{
    class TriArea
    {
        static void Main(string[] args)
        {
            double a1 = double.Parse(Console.ReadLine());
            double h1 = double.Parse(Console.ReadLine());
            double triArea = a1 * h1 / 2;

            Console.WriteLine($"{triArea:f2}");
        }
    }
}
