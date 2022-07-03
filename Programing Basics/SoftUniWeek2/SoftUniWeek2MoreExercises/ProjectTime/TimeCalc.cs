using System;

namespace ProjectTime
{
    internal class TimeCalc
    {
        static void Main(string[] args)
        {
            double hoursRequired = double.Parse(Console.ReadLine());
            int daysGiven = int.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());

            double actualWorkDays = daysGiven - (daysGiven * 0.1);
            double overtimeHours = (daysGiven * 2) * overtimeWorkers;
            double workedHours = Math.Floor(overtimeHours + (actualWorkDays * 8));

            if (workedHours >= hoursRequired)
            {
                workedHours = workedHours - hoursRequired;
                Console.WriteLine($"Yes!{workedHours} hours left.");
            }
            else
            {
                hoursRequired = hoursRequired - workedHours;
                Console.WriteLine($"Not enough time!{hoursRequired} hours needed.");
            }
        }
    }
}
