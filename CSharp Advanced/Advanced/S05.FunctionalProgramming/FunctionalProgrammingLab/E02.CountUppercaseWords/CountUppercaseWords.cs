using System;
using System.Linq;

namespace E02.CountUppercaseWords
{
    internal class CountUppercaseWords
    {
        public static object Enviroment { get; private set; }

        static void Main(string[] args)
        {
            Func<string, bool> checkForUpper = w => char.IsUpper(w[0]);

            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(checkForUpper).ToArray();

            Console.WriteLine(String.Join(Environment.NewLine, strings));
        }
    }
}