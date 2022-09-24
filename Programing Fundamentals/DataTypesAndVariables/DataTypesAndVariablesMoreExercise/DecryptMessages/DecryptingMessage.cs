using System;

namespace DecryptMessages
{
    internal class DecryptingMessage
    {
        static void Main(string[] args)
        {
            int asciiOffset = int.Parse(Console.ReadLine());
            int reads = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < reads; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                message+= (char)((int)letter+asciiOffset);
            }

            Console.WriteLine(message);
        }
    }
}