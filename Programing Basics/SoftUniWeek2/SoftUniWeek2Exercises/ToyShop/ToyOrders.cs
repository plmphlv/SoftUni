using System;

namespace ToyShop
{
    internal class ToyOrders
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzelsCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int plushyBearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            int toyCount = puzzelsCount + dollCount + plushyBearsCount + minionsCount + trucksCount;
            double puzzlePrice = puzzelsCount * 2.60;
            double dollPrice = dollCount * 3.00;
            double plushyBrearsPrice = plushyBearsCount * 4.10;
            double minionsPrice = minionsCount * 8.20;
            double truckPrice = trucksCount * 2.00;

            double totalPrice = puzzlePrice + dollPrice + plushyBrearsPrice + minionsPrice + truckPrice;
            
            if (toyCount >= 50)
            {
                totalPrice = totalPrice - (totalPrice * 0.25);
            }

            totalPrice = totalPrice - (totalPrice * 0.10);

            if (totalPrice>=vacationPrice)
            {
                totalPrice = totalPrice - vacationPrice;
                Console.WriteLine($"Yes! {totalPrice:f2} lv left.");
            }
            else
            {
                totalPrice = vacationPrice - totalPrice;
                Console.WriteLine($"Not enough money! {totalPrice:f2} lv needed.");
            }

        }
    }
}
