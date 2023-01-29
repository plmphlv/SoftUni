using System;
using System.Collections.Generic;
using System.Linq;

namespace E07.PredicateForNames
{
    internal class PredicateForNames
    {
        static void Main(string[] args)
        {
            int maxLenght = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<List<string>, Predicate<string>, List<string>> filter = (names, rightLenght) =>
            {
                List<string> corectNames = new List<string>();
                foreach (string name in names)
                {
                    if (rightLenght(name))
                    {
                        corectNames.Add(name);
                    }
                }
                return corectNames;
            };

            names = filter(names, n => n.Length <= maxLenght);

            Console.WriteLine(String.Join(Environment.NewLine, names));
        }
    }
}