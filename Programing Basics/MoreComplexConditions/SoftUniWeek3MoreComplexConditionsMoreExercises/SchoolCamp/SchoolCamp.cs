using System;

namespace SchoolCamp
{
    internal class SchoolCamp
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentCount = int.Parse(Console.ReadLine());
            int nightCount = int.Parse(Console.ReadLine());

            string activity = string.Empty;
            double nightCost = 0;

            if (groupType == "girls")
            {
                if (season == "Winter")
                {
                    nightCost = 9.60;
                    activity = "Gymnastics";
                }
                else if (season == "Spring")
                {
                    nightCost = 7.2;
                    activity = "Athletics";
                }
                else if (season == "Summer")
                {
                    nightCost = 15;
                    activity = "Volleyball";
                }
            }
            else if (groupType == "boys")
            {
                if (season == "Winter")
                {
                    nightCost = 9.60;
                    activity = "Judo";
                }
                else if (season == "Spring")
                {
                    nightCost = 7.2;
                    activity = "Tennis";
                }
                else if (season == "Summer")
                {
                    nightCost = 15;
                    activity = "Football";
                }
            }
            else if (groupType == "mixed")
            {
                if (season == "Winter")
                {
                    nightCost = 10;
                    activity = "Ski";
                }
                else if (season == "Spring")
                {
                    nightCost = 9.5;
                    activity = "Cycling";
                }
                else if (season == "Summer")
                {
                    nightCost = 20;
                    activity = "Swimming";
                }
            }

            double campCost = (nightCost * nightCount) * studentCount;

            if (studentCount >= 10 && studentCount < 20)
                campCost = campCost - (campCost * 0.05);
            else if (studentCount >= 20 && studentCount < 50)
                campCost = campCost - (campCost * 0.15);
            else if (studentCount >= 50)
                campCost = campCost - (campCost * 0.5);

            Console.WriteLine($"{activity} {campCost:f2} lv.");
        }
    }
}

