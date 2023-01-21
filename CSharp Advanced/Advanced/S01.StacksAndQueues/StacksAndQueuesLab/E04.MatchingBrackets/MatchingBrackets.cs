using System;
using System.Collections.Generic;

namespace E04.MatchingBrackets
{
    internal class MatchingBrackets
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int end = stack.Pop();

                    Console.WriteLine(input.Substring(end, i - end + 1));
                }
            }
        }
    }
}