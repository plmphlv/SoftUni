using System;
using System.Collections.Generic;

namespace E06.RecordUniqueNames
{
    internal class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            HashSet<string> setOfNames = new HashSet<string>();

            for (int i = 0; i < loops; i++)
            {
                setOfNames.Add(Console.ReadLine());
            }

            Console.WriteLine(String.Join(Environment.NewLine, setOfNames));
        }
    }
}