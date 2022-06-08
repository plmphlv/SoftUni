using System;

namespace WeatherApp2
{
    class WeatherApp2
    {
        static void Main(string[] args)
        {
            double temp = double.Parse(Console.ReadLine());

            if (temp >= 26.00 && temp <= 35.00)
            {
                Console.WriteLine("Hot");
            }

            else if (temp>=20.10 && temp<=25.90)
            {
                Console.WriteLine("Warm");
            }

            else if (temp >= 15.00 && temp <= 20.00)
            {
                Console.WriteLine("Mild");
            }

            else if (temp >= 12.00 && temp <= 14.90)
            {
                Console.WriteLine("Cool");
            }

            else if (temp >= 5.00 && temp <= 11.90)
            {
                Console.WriteLine("Cold");
            }

            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
