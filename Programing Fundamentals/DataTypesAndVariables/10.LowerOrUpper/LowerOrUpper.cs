using System;

namespace _10.LowerOrUpper
{
    internal class LowerOrUpper
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            bool isUpper = (Char.IsUpper(letter));

            if (isUpper)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}