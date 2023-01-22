using System;
using System.Collections.Generic;

namespace E01.UniqueUsernames
{
    internal class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int numUsers = int.Parse(Console.ReadLine());

            HashSet<string> users = new HashSet<string>();

            for (int i = 0; i < numUsers; i++)
            {
                users.Add(Console.ReadLine());
            }

            Console.WriteLine(String.Join(Environment.NewLine, users));
        }
    }
}