using System;

namespace BikeRace
{
    internal class BikeRace
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string raceType = Console.ReadLine();

            double charityDonation = 0;

            if (raceType == "trail")
            {
                charityDonation = (juniors * 5.5) + (seniors * 7);
            }
            else if (raceType == "cross-country")
            {
                charityDonation = (juniors * 8) + (seniors * 9.50);
            }
            else if (raceType == "downhill")
            {
                charityDonation = (juniors * 12.25) + (seniors * 13.75);
            }
            else if (raceType == "road")
            {
                charityDonation = (juniors * 20) + (seniors * 21.50);
            }

            if (juniors + seniors >= 50 && raceType == "cross-country")
            {
                charityDonation = charityDonation - (charityDonation * 0.25);
            }

            charityDonation = charityDonation - (charityDonation * 0.05);

            Console.WriteLine($"{charityDonation:f2}");
        }
    }
}
