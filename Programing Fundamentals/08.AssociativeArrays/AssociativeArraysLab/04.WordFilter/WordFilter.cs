using System;
using System.Linq;

namespace _04.WordFilter
{
    internal class WordFilter
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();

            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}