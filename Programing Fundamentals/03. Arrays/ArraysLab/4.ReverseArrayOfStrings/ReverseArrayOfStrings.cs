using System;
using System.Linq;

namespace _4.ReverseArrayOfStrings
{
    internal class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] myWords = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < myWords.Length / 2; i++)
            {
                string oldElement = myWords[i];
                myWords[i] = myWords[myWords.Length-1-i];
                myWords[myWords.Length-1-i]=oldElement;
            }

            Console.WriteLine(string.Join(" ", myWords));
        }
    }
}