using System;
using System.Linq;

namespace _2.CommonElements
{
    internal class CommonElements
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();

            string[] commonElements = new string[(Math.Max(arr1.Length, arr2.Length) * 2)];

            int commonCounter = 0;

            for (int j = 0; j < arr2.Length; j++)
            {
                for (int i = arr1.Length - 1; i >= 0; i--)
                {
                    if (arr1[i] == arr2[j])
                    {
                        commonElements[commonCounter] = arr2[j];
                        commonCounter++;
                        break;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", commonElements));
        }
    }
}
