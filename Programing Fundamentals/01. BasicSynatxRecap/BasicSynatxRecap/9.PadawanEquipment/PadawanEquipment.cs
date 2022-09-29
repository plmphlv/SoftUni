using System;

namespace _9.PadawanEquipment
{
    internal class PadawanEquipment
    {
        static void Main(string[] args)
        {
            double credits = double.Parse(Console.ReadLine());
            int padawans = int.Parse(Console.ReadLine());
            double pricePerLightsaber = double.Parse(Console.ReadLine());
            double prircePerRobe = double.Parse(Console.ReadLine());
            double pricePerbelt = double.Parse(Console.ReadLine());

            double lightsaberPrice = pricePerLightsaber * Math.Ceiling((padawans * 1.1));
            double rodePrice = prircePerRobe * padawans;

            double beltPrice;
            if (padawans >= 6)
            {
                beltPrice = pricePerbelt * (padawans - (padawans / 6));
            }
            else
            {
                beltPrice = pricePerbelt * padawans;
            }

            double total = beltPrice + lightsaberPrice + rodePrice;
            if (total <= credits)
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            else
                Console.WriteLine($"John will need {total - credits:f2}lv more.");
        }
    }
}
