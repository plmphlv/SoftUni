using System;

namespace TrainTheTrainers
{
    internal class TrainTheTrainers
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());

            string presentation;
            double finalGrade = 0;
            int presentationCount = 0;

            while ((presentation = Console.ReadLine()) != "Finish")
            {
                double grade = 0;
                presentationCount++;

                for (int i = 1; i <= judges; i++)
                {
                    double judjeMark = double.Parse(Console.ReadLine());
                    grade += judjeMark;
                }

                grade = grade / judges;
                Console.WriteLine($"{presentation} - {grade:f2}.");
                finalGrade += grade;
            }
            finalGrade /= presentationCount;
            Console.WriteLine($"Student's final assessment is {finalGrade:f2}.");
        }
    }
}