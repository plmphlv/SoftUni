using System;

namespace SpecialNumbers
{
    internal class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {

                int currCandidate = i;
                bool isSpecial = true;

                while (currCandidate > 0)
                {
                    int currDigit = currCandidate % 10;
                    currCandidate = currCandidate / 10;

                    if ((currDigit == 0) || n % currDigit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }
                if (isSpecial)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}