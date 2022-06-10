using System;

namespace WeatherApp1
{
    class WeatherApp1
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();
            if (weather == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (weather == "cloudy")
            {
                Console.WriteLine("It's cold outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
