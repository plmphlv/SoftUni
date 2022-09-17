using System;

namespace _10.RageExpenses
{
    internal class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice=double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double trashedHeadsets = headsetPrice * (lostGames / 2);
            double trashedMice = mousePrice * (lostGames / 3);
            double trashedKeyboard = keyboardPrice * (lostGames / 6);
            double trashedDisplays = displayPrice * (lostGames / 12);

            double rageCost=trashedDisplays+trashedHeadsets+trashedKeyboard+trashedMice;

            Console.WriteLine($"Rage expenses: {rageCost:f2} lv.");
        }
    }
}
