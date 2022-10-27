using System;
using System.Linq;

namespace _01.RandomizeWords
{
    internal class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] senance = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Random rng = new Random();

            for (int i = 0; i < senance.Length; i++)
            {
                int randomNum= rng.Next(0, senance.Length);
                
                string word1 = senance[i];
                senance[i] = senance[randomNum];
                senance[randomNum] = word1;
            }

            Console.WriteLine(String.Join(Environment.NewLine,senance));
        }
    }
}