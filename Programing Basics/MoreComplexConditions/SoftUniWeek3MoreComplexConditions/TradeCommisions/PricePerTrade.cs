using System;

namespace TradeCommisions
{
    internal class PricePerTrade
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());
            double commision = 0;

            switch (city)
            {
                case "Sofia":
                    if (salesVolume >= 0 && salesVolume <= 500)
                    {
                        commision = salesVolume * 0.05; // commision *= 0.05;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (salesVolume > 500 && salesVolume <= 1000)
                    {
                        commision = salesVolume * 0.07; // commision *= 0.07;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                    {
                        commision = salesVolume * 0.08; // commision *= 0.08;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (salesVolume > 10000)
                    {
                        commision = salesVolume * 0.12; // commision *= 0.12
                        Console.WriteLine($"{commision:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (salesVolume >= 0 && salesVolume <= 500)
                    {
                        commision = salesVolume * 0.045; // commision *= 0.045;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (salesVolume > 500 && salesVolume <= 1000)
                    {
                        commision = salesVolume * 0.075; // commision *= 0.075;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                    {
                        commision = salesVolume * 0.1; // commision *= 0.1;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (salesVolume > 10000)
                    {
                        commision = salesVolume * 0.13; // commision *= 0.13;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (salesVolume >= 0 && salesVolume <= 500)
                    {
                        commision = salesVolume * 0.055; // commision *= 0.055;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (salesVolume > 500 && salesVolume <= 1000)
                    {
                        commision = salesVolume * 0.08; // commision *= 0.08;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                    {
                        commision = salesVolume * 0.12; // commision *= 0.12;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (salesVolume > 10000)
                    {
                        commision = salesVolume * 0.145; // commision *= 0.145
                        Console.WriteLine($"{commision:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
        }
    }
}
