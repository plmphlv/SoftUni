using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.AverageStudentGrades
{
    internal class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentRecord = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < loops; i++)
            {
                string[] student = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!studentRecord.ContainsKey(student[0]))
                {
                    studentRecord[student[0]] = new List<decimal>();
                }
                studentRecord[student[0]].Add(decimal.Parse(student[1]));
            }


            foreach (var item in studentRecord)
            {
                Console.WriteLine($"{item.Key} -> {String.Join(" ", item.Value.Select(x => $"{x:f2}"))} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
