using System;

namespace TrapeziodArea
{
    class Area
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h1 = double.Parse(Console.ReadLine());

            double area = (b1 + b2) * h1 / 2;

            //как се форматира текст за да изписва само два символа след десетичната запетая
            Console.WriteLine($"{area:0.00}");
            Console.WriteLine($"{area:f2}");
        }
    }
}
