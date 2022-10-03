using System;
using System.Linq;

namespace _9.KaminoFactory
{
    internal class KaminoFactory
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());

            int[] bestDna = new int[dnaLenght];
            int bestDnaSum = 0;
            int bestDnaIndex = 0;
            int bestSeq = 0;
            int bestSampleNum = 0;

            string command;
            int sampleNum = 0;
            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] currentDNA = command.Split("!").Select(int.Parse).ToArray();
                sampleNum++;

                int currentLeftMostIndex = -1;
                int currSeq = 0;
                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (i != currentDNA.Length - 1)
                    {
                        if (currentDNA[i] == 1 && currentDNA[i + 1] == 1)
                        {
                            currSeq += 2;
                        }
                    }
                    else if (i == currentDNA.Length - 1)
                    {
                        if (currentDNA[i] == currentDNA[i - 1] && currentDNA[i] != 0)
                        {
                            currSeq++;
                            break;
                        }
                    }

                }

                for (int i = 0; i < currentDNA.Length - 1; i++)
                {
                    if (currentDNA[i] == 1 && currentDNA[i + 1] == 1)
                    {
                        currentLeftMostIndex = i;
                        break;
                    }
                }
                //1!1!0!1

                int currentDnaSum = currentDNA.Sum();

                if (currSeq > bestSeq)
                {
                    bestDna = currentDNA;
                    bestDnaSum = currentDNA.Sum();
                    bestDnaIndex = currentLeftMostIndex;
                    bestSeq = currSeq;
                    bestSampleNum = sampleNum;
                }
                else if (currSeq == bestSeq && currentLeftMostIndex < bestDnaIndex)
                {
                    bestDna = currentDNA;
                    bestDnaSum = currentDNA.Sum();
                    bestDnaIndex = currentLeftMostIndex;
                    bestSeq = currSeq;
                    bestSampleNum = sampleNum;
                }
                else if (currSeq == bestSeq && currentLeftMostIndex == bestDnaIndex && currentDnaSum > bestDnaSum)
                {
                    bestDna = currentDNA;
                    bestDnaSum = currentDNA.Sum();
                    bestDnaIndex = currentLeftMostIndex;
                    bestSeq = currSeq;
                    bestSampleNum = sampleNum;
                }

            }

            Console.WriteLine($"Best DNA sample {bestSampleNum} with sum: {bestDnaSum}.");
            Console.WriteLine(String.Join(" ", bestDna));
        }
    }
}