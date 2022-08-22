using System;

namespace Graduation
{
    internal class Graduation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double gradeMarks = 0;
            int failScore = 0;

            while(grade<=12)
            {
                double yearMark =double.Parse(Console.ReadLine());

                
                if (yearMark<4.00)
                {
                    failScore++;
                    if (failScore > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }
                

                grade++;
                gradeMarks +=yearMark;
            }

            gradeMarks /= 12;

            Console.WriteLine($"{name} graduated. Average grade: {gradeMarks:f2}");
        }
    }
}
