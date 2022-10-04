using System;
using System.Linq;

namespace _9.KaminoFactory
{
    internal class KaminoFactory
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            int[] bestSample = new int[dnaLength];
            int bestSampleLength = int.MinValue;
            int bestSampleIndex = int.MinValue;
            int bestSampleSum = int.MinValue;
            int bestSampleStart = -1;
            int index = 1;

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] data = command.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int currentSampleLength = int.MinValue;
                int currenSampletIndex = int.MinValue;
                int currentSubLength = 0;
                int currentSubIndex = 0;
                bool isOne = false;

                for (int i = 0; i < dnaLength; i++)
                {
                    if (data[i] == 1 && isOne)
                    {
                        currentSubLength++;
                    }
                    else if (data[i] == 1)
                    {
                        isOne = true;
                        currentSubIndex = i;
                        currentSubLength = 1;
                    }
                    else if (data[i] == 0 && isOne)
                    {
                        if (currentSubLength > currentSampleLength)
                        {
                            currentSampleLength = currentSubLength;
                            currenSampletIndex = currentSubIndex;
                        }
                        isOne = false;
                        currentSubLength = 0;
                        currentSubIndex = 0;
                    }
                }

                if (isOne)
                {
                    if (currentSubLength > currentSampleLength)
                    {
                        currentSampleLength = currentSubLength;
                        currenSampletIndex = currentSubIndex;
                    }
                }

                if (currentSampleLength > bestSampleLength)
                {
                    bestSampleLength = currentSampleLength;
                    bestSampleIndex = currenSampletIndex;
                    bestSampleSum = data.Sum();
                    bestSample = data;
                    bestSampleStart = index;
                }
                else if (currentSampleLength == bestSampleLength)
                {
                    if (currenSampletIndex < bestSampleIndex)
                    {
                        bestSampleLength = currentSampleLength;
                        bestSampleIndex = currenSampletIndex;
                        bestSampleSum = data.Sum();
                        bestSample = data;
                        bestSampleStart = index;
                    }
                    else if (currenSampletIndex == bestSampleIndex)
                    {
                        if (data.Sum() > bestSampleSum)
                        {
                            bestSampleLength = currentSampleLength;
                            bestSampleIndex = currenSampletIndex;
                            bestSampleSum = data.Sum();
                            bestSample = data;
                            bestSampleStart = index;
                        }
                    }
                }
                index++;
            }

            Console.WriteLine($"Best DNA sample {bestSampleStart} with sum: {bestSampleSum}.");
            Console.WriteLine(string.Join(" ", bestSample));

        }
    }
}