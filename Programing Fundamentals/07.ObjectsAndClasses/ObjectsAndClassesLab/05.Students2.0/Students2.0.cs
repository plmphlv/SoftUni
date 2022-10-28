using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students2._0
{
    internal class Students2
    {
        static void Main(string[] args)
        {
            List<Student> studentRecords = new List<Student>();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {

                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();



                Student student = studentRecords.FirstOrDefault(s => s.FirstName == cmdArgs[0] && s.LastName == cmdArgs[1]);

                if (student == null)
                {

                    student = new Student(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), cmdArgs[3]);
                    studentRecords.Add(student);

                }
                else
                {

                    student.FirstName = cmdArgs[0];
                    student.LastName = cmdArgs[1];
                    student.Age = int.Parse(cmdArgs[2]);
                    student.Town = cmdArgs[3];

                }

            }

            string townFilter = Console.ReadLine();

            List<Student> studentsByTown = studentRecords.Where(x => x.Town == townFilter).ToList();

            foreach (var student1 in studentsByTown)
            {
                Console.WriteLine($"{student1.FirstName} {student1.LastName} is {student1.Age} years old.");
            }

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