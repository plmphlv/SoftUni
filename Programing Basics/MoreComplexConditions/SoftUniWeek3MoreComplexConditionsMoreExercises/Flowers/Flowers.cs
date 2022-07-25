using System;

namespace Flowers
{
    internal class Flowers
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            char praznik = char.Parse(Console.ReadLine());

            double buketCena = 0;

            if (sezon == "Spring" || sezon == "Summer")
            {
                buketCena = (hrizantemi * 2) + (rozi * 4.1) + (laleta * 2.5);
            }
            else if (sezon == "Autumn" || sezon == "Winter")
            {
                buketCena = (hrizantemi * 3.75) + (rozi * 4.50) + (laleta * 4.15);
            }

            if (praznik == 'Y')
            {
                buketCena = buketCena + (buketCena * 0.15);
            }

            if (laleta > 7 && sezon == "Spring")
            {
                buketCena = buketCena - (buketCena * 0.05);
            }
            if (rozi >= 10 && sezon == "Winter")
            {
                buketCena = buketCena - (buketCena * 0.1);
            }
            if (laleta + hrizantemi + rozi > 20)
            {
                buketCena = buketCena - (buketCena * 0.2);
            }

            Console.WriteLine($"{buketCena+2:f2}");
        }
    }
}
