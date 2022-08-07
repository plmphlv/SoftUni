using System;

namespace Grades
{
    internal class Grades
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());

            double gradesTotal = 0;

            double excelentMarks = 0;
            double goodMarks = 0;
            double averageMark = 0;
            double failMark = 0;

            int topStudents = 0;
            int goodStudents = 0;
            int averageStudents = 0;
            int failStudents = 0;

            for (int student = 1; student <= studentCount; student++)
            {
                double score = double.Parse(Console.ReadLine());

                if (score >= 2.00 && score <= 2.99)
                {
                    failMark += score;
                    failStudents++;
                }
                else if (score >= 3.00 && score <= 3.99)
                {
                    averageMark += score;
                    averageStudents++;
                }
                else if (score >= 4.00 && score <= 4.99)
                {
                    goodMarks += score;
                    goodStudents++;
                }
                else if (score >= 5.00)
                {
                    excelentMarks += score;
                    topStudents++;
                }

                gradesTotal += score;
            }

            double averageScore = gradesTotal / studentCount;

            double failScore = ((double)failStudents / (double)studentCount)*100;
            double averageStudentsScore = ((double)averageStudents / (double)studentCount)*100;
            double goodStudentsScore = ((double)goodStudents / (double)studentCount)*100;
            double excelentStudentsScore = ((double)topStudents / (double)studentCount)*100;

            Console.WriteLine($"Top students: {excelentStudentsScore:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {goodStudentsScore:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {averageStudentsScore:f2}%");
            Console.WriteLine($"Fail: {failScore:f2}%");
            Console.WriteLine($"Average: {averageScore:f2}");
        }
    }
}
