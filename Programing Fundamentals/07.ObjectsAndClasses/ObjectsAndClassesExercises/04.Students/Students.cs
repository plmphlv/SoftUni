using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace _04.Students
{
    internal class Students
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int numOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfStudents; i++)
            {

                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Student student = new Student(cmdArgs[0], cmdArgs[1], double.Parse(cmdArgs[2]));
                students.Add(student);

            }

            foreach (Student student in students.OrderByDescending(x=>x.Grade))
            {

                Console.WriteLine(student.ToString());

            }

        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }

    }

}