using System;

namespace _7.RepeatString
{
    internal class RepeatString
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int loop = int.Parse(Console.ReadLine());

            string finalWord = RepeatWord(word, loop);
            Console.WriteLine(finalWord);
        }

        static string RepeatWord(string word, int count)
        {
            string result=string.Empty;

            for (int i = 1; i <= count; i++)
            {
                result += word;
            }
            return result;
        }
    }
}