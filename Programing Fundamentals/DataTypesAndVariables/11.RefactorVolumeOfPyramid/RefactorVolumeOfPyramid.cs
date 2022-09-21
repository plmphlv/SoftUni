using System;

namespace _11.RefactorVolumeOfPyramid
{
    internal class RefactorVolumeOfPyramid
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Length: ");
            double lenght = double.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Heigth: ");
            double height = double.Parse(Console.ReadLine());


            double volume = (lenght + width + height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}