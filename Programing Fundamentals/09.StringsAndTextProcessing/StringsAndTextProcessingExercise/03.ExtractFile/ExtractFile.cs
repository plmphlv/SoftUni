using System;

namespace _03.ExtractFile
{
    internal class ExtractFile
    {
        static void Main(string[] args)
        {
            char[] separators = { ':', '\\', '.' };

            string[] path = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string fileName = path[path.Length - 2];
            string fileExtenshion = path[path.Length - 1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtenshion}");
        }
    }
}