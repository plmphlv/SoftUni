using System;
using System.Linq;

namespace E03.AddVAT
{
    internal class AddVAT
    {
        static void Main(string[] args)
        {
            Func<string, double> vat = x => double.Parse(x) * 1.2;

            double[] prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x => vat(x)).ToArray();

            Console.WriteLine(String.Join(Environment.NewLine, prices.Select(x => $"{x:f2}")));
        }
    }
}