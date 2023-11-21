using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E01.Messaging
{
    internal class Messaging
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            StringBuilder phrase = new StringBuilder();

            phrase.Append(Console.ReadLine());

            StringBuilder word = new StringBuilder();

            foreach (int numMember in numbers)
            {

                int nun = numMember;
                int sum = 0;

                while (nun != 0)
                {
                    sum += nun % 10;
                    nun /= 10;
                }

                if (sum >= phrase.Length)
                {
                    sum -= phrase.Length;
                }

                word.Append(phrase[sum]);
                phrase.Remove(sum, 1);

            }

            Console.WriteLine(word);

        }
    }
}