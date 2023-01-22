using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.CountSymbols
{
    internal class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> symbols = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (!symbols.ContainsKey(c))
                {
                    symbols[c] = 0;
                }

                symbols[c]++;
            }

            symbols = symbols.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);

            Console.WriteLine(String.Join(Environment.NewLine, symbols.Select(c => $"{c.Key}: {c.Value} time/s")));
        }
    }
}