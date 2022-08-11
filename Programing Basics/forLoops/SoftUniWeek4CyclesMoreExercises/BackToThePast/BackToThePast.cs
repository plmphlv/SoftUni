using System;

namespace BackToThePast
{
    internal class BackToThePast
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int yearTarget = int.Parse(Console.ReadLine());

            double moneyNeed = 0;
            

            for (int year = 1800; year <= yearTarget; year++)
            {
                
                if (year % 2 == 0)
                {
                    moneyNeed += 12000;
                }
                else
                {
                    moneyNeed += 12000 + (50 * (18+(year-1800)));
                }
            }

            if (money>=moneyNeed)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money - moneyNeed:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {moneyNeed - money:f2} dollars to survive.");
            }
        }
    }
}
