using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    internal class Students
    {
        static void Main(string[] args)
        {

            List<Student> studentRecords = new List<Student>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {

                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Student student = new Student(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), cmdArgs[3]);
                studentRecords.Add(student);

            }

            string townFilter = Console.ReadLine();

            List<Student> studentsByTown = studentRecords.Where(x => x.Town == townFilter).ToList();

            foreach (var student in studentsByTown)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }

        class Student
        {

            public Student(string firstName, string lastName, int age, string town)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Town = town;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Town { get; set; }
        }
    }
}
