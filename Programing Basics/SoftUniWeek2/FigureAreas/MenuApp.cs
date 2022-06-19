using System;

namespace FigureAreas
{
    class MenuApp
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure== "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area= (side * height)/2;
                Console.WriteLine($"{area:f3}");
            }

            if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.Pow(radius,2)*Math.PI;
                Console.WriteLine($"{area:f3}");
            }

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine($"{area:f3}");
            }

            if (figure == "rectangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = side * height;
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
