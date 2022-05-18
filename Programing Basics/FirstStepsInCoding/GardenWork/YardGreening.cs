using System;

namespace GardenWork
{
    class YardGreening
    {
        static void Main(string[] args)
        {
            double yard = double.Parse(Console.ReadLine());
            double price = 7.61;
            double workPrice = yard * price;
            double discount = 0.18 * workPrice;
            double finalPrice = workPrice - discount;
            Console.WriteLine($"The final price is {finalPrice} lv.");
            Console.WriteLine($"The discount is {discount} lv.");
        }
    }
}
