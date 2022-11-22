using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            StringBuilder stringBuilder = new StringBuilder();

            int remainder = 0;

            if (bigNum == "0" || secondNum == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(bigNum[i].ToString());
                int product = digit * secondNum + remainder;
                int result = product % 10;
                remainder = product / 10;

                stringBuilder.Insert(0, result);
            }

            if (remainder > 0)
            {
                stringBuilder.Insert(0, remainder);
            }

            Console.WriteLine(stringBuilder.ToString());

        }
    }
}using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            StringBuilder stringBuilder = new StringBuilder();

            int remainder = 0;

            if (bigNum == "0" || secondNum == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(bigNum[i].ToString());
                int product = digit * secondNum + remainder;
                int result = product % 10;
                remainder = product / 10;

                stringBuilder.Insert(0, result);
            }

            if (remainder > 0)
            {
                stringBuilder.Insert(0, remainder);
            }

            Console.WriteLine(stringBuilder.ToString());

        }
    }
}