using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _08.AnonymousThreat
{
    internal class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;

            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (cmdArgs[0] == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    FixIndexes(words, ref startIndex, ref endIndex);
                    WordMerge(ref words, startIndex, endIndex);
                }
                else if (cmdArgs[0] == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partitions = int.Parse(cmdArgs[2]);
                    DivideWord(ref words, index, partitions);

                }

                Console.WriteLine(string.Join(" ", words));
            }
        }

        static void DivideWord(ref List<string> words,int index,int partitions)
        {
            List<string> subWordsList = new List<string>();

            string word = words[index];
            int subLenght = word.Length / partitions;
            int lastSubLenght = word.Length - ((partitions - 1) * subLenght);

            for (int i = 1; i < partitions; i++)
            {
                int preffLenght = subLenght;
                if (i == partitions - 1)
                {
                    preffLenght = lastSubLenght;
                }
                char[] newPart = word.Skip(i * subLenght).Take(preffLenght).ToArray();
                subWordsList.Add(string.Join("", newPart));
            }
            words.RemoveAt(index);
            words.InsertRange(index, subWordsList);
        }
        static void FixIndexes(List<string>word, ref int start, ref int end)
        {
            if (end >= word.Count)
            {
                end = word.Count - 1;
            }

            if (start < 0)
            {
                start = 0;
            }
            
            if (end < 0)
            {
                end = 0;
            }

            if (start >= word.Count)
            {
                start = word.Count-1;
            }
        }

        static void WordMerge(ref List<string> word, int startIndex, int endIndex)
        {
            string mergedWord = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                mergedWord += word[startIndex];
                word.RemoveAt(startIndex);
            }

            word.Insert(startIndex, mergedWord);
        }
    }
}