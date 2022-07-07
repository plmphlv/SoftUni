using System;

namespace CatPlayTime
{
    internal class PlayTime
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int workDays = 365 - daysOff;
            int daysOffPlay = daysOff * 127;
            int workDaysPlay = workDays * 63;
            int totalPlayTime = daysOffPlay + workDaysPlay;

            if (totalPlayTime > 30000)
            {
                int hours = (totalPlayTime - 30000) / 60;
                int minutes = (totalPlayTime - 30000) % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                int hours = (30000 - totalPlayTime) / 60;
                int minutes = (30000 - totalPlayTime) % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
