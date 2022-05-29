using System;

namespace SchoolMaretials
{
    class MaterialsPrice
    {
        static void Main(string[] args)
        {
            int penPack = int.Parse(Console.ReadLine());
            int markerPack = int.Parse(Console.ReadLine());
            int cleanerQty = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine())/100;/* Когато имам да смятат процент. Винаги с double се декларира променливата.
            Ако е с int се разваля уравнението*/


            double totalPrice = penPack * 5.80 + markerPack * 7.20 + cleanerQty * 1.20;
            double endPrice = totalPrice - (totalPrice * discount);


            Console.WriteLine(endPrice);
        }
    }
}
