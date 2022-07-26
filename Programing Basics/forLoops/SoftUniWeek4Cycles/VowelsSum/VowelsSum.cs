using System;

namespace VowelsSum
{
    internal class VowelsSum
    {
        static void Main(string[] args)
        {
            string input= Console.ReadLine();
            int sum = 0;
            
            for(int i = 0; i <= input.Length-1; i++)
            {
                switch(input[i])
                {
                    case 'a':
                        sum = sum + 1;
                        break;
                        case 'e':
                        sum = sum + 2;
                        break;
                    case 'i':
                        sum = sum + 3;
                        break;
                    case 'o':
                        sum = sum + 4;
                        break;
                    case 'u':
                        sum = sum + 5;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
