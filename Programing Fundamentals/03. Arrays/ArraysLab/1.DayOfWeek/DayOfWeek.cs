using System;

namespace _1.DayOfWeek
{
    internal class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int dayIndex = int.Parse(Console.ReadLine()) - 1;

            string day = (dayIndex >= 0 && dayIndex <= 6) ? daysOfWeek[dayIndex] : "Invalid day!";

            Console.WriteLine(day);
        }
    }
}