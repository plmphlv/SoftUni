using System;

namespace _9.PalindromeIntegers
{
    internal class PalindromeIntegers
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine().ToUpper() ) != "END")
            {
                int number = int.Parse(command);
                Console.WriteLine(ReverseInt(number));
            }
        }

        static string ReverseInt(int num)
        {
            int copyNum = num;
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return (copyNum == result) ? "true" : "false";
        }
    }
}