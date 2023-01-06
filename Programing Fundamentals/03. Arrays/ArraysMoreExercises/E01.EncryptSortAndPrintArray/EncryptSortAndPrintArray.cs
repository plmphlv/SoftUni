using System;
using System.Linq;

namespace E01.EncryptSortAndPrintArray
{
    internal class EncryptSortAndPrintArray
    {
        static void Main(string[] args)
        {
            int numOfElements = int.Parse(Console.ReadLine());

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            int[] sums = new int[numOfElements];

            for (int i = 0; i < numOfElements; i++)
            {

                string name = Console.ReadLine();

                int nameSum = 0;

                for (int j = 0; j < name.Length; j++)
                {

                    char letter = name[j];

                    if (vowels.Contains(char.ToLower(letter)))
                    {
                        nameSum += (int)letter * name.Length;
                    }
                    else
                    {
                        nameSum += (int)letter / name.Length;
                    }

                }

                sums[i] = nameSum;

            }

            Array.Sort(sums);

            foreach (int i in sums)
            {
                Console.WriteLine(i);
            }
        }
    }
}