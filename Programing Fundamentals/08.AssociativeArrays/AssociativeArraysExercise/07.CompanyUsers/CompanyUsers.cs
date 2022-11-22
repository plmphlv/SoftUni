using System;
using System.Collections.Generic;

namespace _07.CompanyUsers
{
    internal class CompanyUsers
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {

                string[] cmdArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string company = cmdArgs[0];
                string employeId = cmdArgs[1];

                if (!companies.ContainsKey(company))
                {
                    companies[company] = new List<string>();
                }
                if (!companies[company].Contains(employeId))
                {
                    companies[company].Add(employeId);
                }

            }

            foreach (var item in companies)
            {

                Console.WriteLine($"{item.Key}");
                foreach (string student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }

            }
        }
    }
}