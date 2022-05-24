using System;

namespace VacationBooks
{
    class ReadtimeCalc
    {
        static void Main(string[] args)
        {
            int numPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numDays = int.Parse(Console.ReadLine());

            int hoursPerDay = (numPages / pagesPerHour) / numDays;
            Console.WriteLine(hoursPerDay);
        }
    }
}
