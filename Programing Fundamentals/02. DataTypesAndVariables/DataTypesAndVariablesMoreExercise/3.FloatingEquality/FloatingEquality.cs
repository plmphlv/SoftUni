using System;

namespace _3.FloatingEquality
{
    internal class FloatingEquality
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double diff = Math.Abs(a - b);
            bool equal = (diff < eps);

            Console.WriteLine(equal);
        }
    }
}