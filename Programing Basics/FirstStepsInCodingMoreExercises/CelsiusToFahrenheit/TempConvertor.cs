using System;

namespace CelsiusToFahrenheit
{
    class TempConvertor
    {
        static void Main(string[] args)
        {
            double celceus = double.Parse(Console.ReadLine());
            double farenheight = celceus * 1.8 + 32;
            Console.WriteLine($"{farenheight:f2}");
        }
    }
}
