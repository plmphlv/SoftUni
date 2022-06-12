using System;

namespace FarmerProfit
{
    class FarmerProfit
    {
        static void Main(string[] args)
        {
            double veggiePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int veggieKilo = int.Parse(Console.ReadLine());
            int fruitKilo = int.Parse(Console.ReadLine());
            double euro = (veggiePrice * veggieKilo + fruitPrice * fruitKilo) / 1.94;



            Console.WriteLine($"{euro:0.00}");
        }
    }
}
