using System;
using System.Linq;

namespace E04.FoldAndSum
{
    internal class FoldAndSum
    {
        static void Main(string[] args)
        {

            int[] mainArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int foldLenght = mainArray.Length / 2;

            int[] topArr = new int[foldLenght];
            int[] bottomArr = new int[foldLenght];
            int topHalf = mainArray.Length / 4;


            int reverseOrder = topHalf - 1;
            for (int i = 0; i < topHalf; i++)
            {

                topArr[i] = mainArray[reverseOrder--];

            }

            int bottomPosition = 0;
            for (int i = topHalf; i < mainArray.Length - topHalf; i++)
            {

                bottomArr[bottomPosition++] = mainArray[i];

            }

            reverseOrder = topHalf;
            for (int i = mainArray.Length - 1; i >= mainArray.Length - topHalf; i--)
            {

                topArr[reverseOrder++] = mainArray[i];

            }

            for (int i = 0; i < foldLenght; i++)
            {
                Console.Write($"{topArr[i] + bottomArr[i]} ");
            }

        }
    }
}