using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StudentAcademy
{
    internal class StudentAcademy
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int loops = int.Parse(Console.ReadLine());
            for (int i = 0; i < loops; i++)
            {

                string studentName = Console.ReadLine();
                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }
                students[studentName].Add(double.Parse(Console.ReadLine()));

            }



            foreach (var student in students)
            {

                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }

            }

        }
    }
}