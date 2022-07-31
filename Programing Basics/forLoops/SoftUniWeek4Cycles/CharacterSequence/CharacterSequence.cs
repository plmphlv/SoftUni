using System;

namespace CharacterSequence
{
    internal class CharacterSequence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for(int i = 0; i < input.Length; i++)
            {
                char letter=input[i];
                Console.WriteLine(input[i]);
            }
        }
    }
}
