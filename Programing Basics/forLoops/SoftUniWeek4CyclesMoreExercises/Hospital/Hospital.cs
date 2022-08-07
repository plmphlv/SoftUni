using System;

namespace Hospital
{
    internal class Hospital
    {
        static void Main(string[] args)
        {
            int periondOfTime = int.Parse(Console.ReadLine());

            int doctorCount = 7;
            int treatedPationts = 0;
            int untreatetPationts = 0;

            for (int days = 1; days <= periondOfTime; days++)
            {
                if (days % 3 == 0 && untreatetPationts > treatedPationts)
                {
                    doctorCount++;
                }

                int patients = int.Parse(Console.ReadLine());

                if (patients > doctorCount)
                {
                    treatedPationts += doctorCount;
                    untreatetPationts += (patients - doctorCount);
                }
                else
                {
                    treatedPationts += patients;
                }
            }

            Console.WriteLine($"Treated patients: {treatedPationts}.");
            Console.WriteLine($"Untreated patients: {untreatetPationts}.");

        }
    }
}
