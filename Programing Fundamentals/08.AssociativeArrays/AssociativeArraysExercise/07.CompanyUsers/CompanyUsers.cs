using System;
using System.Collections.Generic;

namespace _07.CompanyUsers
{
    internal class CompanyUsers
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {

                string[] cmdArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string cource = cmdArgs[0];
                string student = cmdArgs[1];

                if (!company.ContainsKey(cource))
                {
                    company[cource] = new List<string>();
                }
                if (company[])
                {

                }
                company[cource].Add(student);

            }

            foreach (var item in company)
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