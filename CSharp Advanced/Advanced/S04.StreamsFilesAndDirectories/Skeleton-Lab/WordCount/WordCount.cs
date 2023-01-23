namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(wordsFilePath);
            string[] words;
            using (reader)
            {
                words = reader.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            reader = new StreamReader(textFilePath);
            using (reader)
            {
                string[] splitters = { " ", ",", ", ", ".", "...", "", ", ", "-", "!", "?!", "…", "?", "\r\n" };
                string[] elements = reader.ReadToEnd().ToLower().Split(splitters, StringSplitOptions.RemoveEmptyEntries);

                StreamWriter writer = new StreamWriter(outputFilePath);
                Dictionary<string, int> wordLogs = new Dictionary<string, int>();

                foreach (string keyWord in words)
                {
                    int count = 0;

                    foreach (string item in elements)
                    {
                        if (keyWord == item)
                        {
                            count++;
                        }
                    }
                    wordLogs[keyWord] = count;
                }

                wordLogs = wordLogs.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                using (writer)
                {
                    foreach (var item in wordLogs)
                    {
                        writer.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
            }


        }
    }
}
