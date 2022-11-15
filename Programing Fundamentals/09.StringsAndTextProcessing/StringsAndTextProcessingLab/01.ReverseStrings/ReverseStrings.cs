using System;

namespace _01.ReverseStrings
{
    internal class ReverseStrings
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine())!="end")
            {
                string reversedWord =string.Empty;

                for (int i = command.Length-1; i >= 0; i--)
                {
                    reversedWord += command[i];
                }

                Console.WriteLine($"{command} = {reversedWord}");
            }
        }
    }
}