using System;

namespace ReadText
{
    internal class ReadText
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while(text!="Stop")
            {
                Console.WriteLine(text);
                text = Console.ReadLine();
            }
        }
    }
}
