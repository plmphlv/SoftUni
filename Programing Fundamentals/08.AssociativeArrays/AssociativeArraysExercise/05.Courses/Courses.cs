using System;
using System.Collections.Generic;

namespace _05.Courses
{
    internal class Courses
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> cources = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {

                string[] cmdArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string cource = cmdArgs[0];
                string student = cmdArgs[1];

                if (!cources.ContainsKey(cource))
                {
                    cources[cource] = new List<string>();
                }
                cources[cource].Add(student);

            }

            foreach (var item in cources)
            {

                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (string student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }

            }
        }
    }
}