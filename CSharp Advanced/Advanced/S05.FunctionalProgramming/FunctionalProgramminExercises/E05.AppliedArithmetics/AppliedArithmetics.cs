using System;
using System.Linq;

namespace E05.AppliedArithmetics
{
    internal class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            Func<int[], string, int[]> mathOperations = (numbers, operation) =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    switch (operation)
                    {
                        case "add":
                            numbers[i] += 1;
                            break;

                        case "multiply":
                            numbers[i] *= 1;
                            break;

                        case "subtract":
                            numbers[i] -= 1;
                            break;

                        default:
                            break;
                    }
                }
                return numbers;
            };

            Action<int[]> printNumbers = (nums) =>
            {
                Console.WriteLine(String.Join(" ", nums));
            };

            int[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "print")
                {
                    printNumbers(range);
                }
                else
                {
                    range = mathOperations(range, command);
                }
            }
        }
    }
}