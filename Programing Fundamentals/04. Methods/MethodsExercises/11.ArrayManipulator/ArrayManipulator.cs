using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    internal class ArrayManipulator
    {
        static void Main(string[] args)
        {
            int[] myArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] manipulationsCommand = command.Split().ToArray();
                int indexResult = -1;

                switch (manipulationsCommand[0])
                {
                    case "exchange":
                        int arrIndex = int.Parse(manipulationsCommand[1]);

                        if (arrIndex < 0 || arrIndex >= myArray.Length)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        myArray = ExchangeArray(myArray, arrIndex);
                        break;

                    case "max":

                        if (manipulationsCommand[1] == "even")
                        {
                            indexResult = MaxEvenIndex(myArray);
                        }
                        else if (manipulationsCommand[1] == "odd")
                        {
                            indexResult = MaxOddIndex(myArray);
                        }

                        if (indexResult < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(indexResult);
                        }

                        break;

                    case "min":

                        if (manipulationsCommand[1] == "even")
                        {
                            indexResult = MinEvenIndex(myArray);
                        }
                        else if (manipulationsCommand[1] == "odd")
                        {
                            indexResult = MinOddIndex(myArray);
                        }

                        if (indexResult < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(indexResult);
                        }

                        break;

                    case "first":
                        int index = int.Parse(manipulationsCommand[1]);

                        if (index > myArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }

                        int[] firstElements = new int[index];

                        if (manipulationsCommand[2] == "even")
                        {
                            firstElements = FirstEvenPrinting(myArray, index);
                        }
                        else if (manipulationsCommand[2] == "odd")
                        {
                            firstElements = FirstOddPrinting(myArray, index);
                        }

                        PrintArray(firstElements);

                        break;

                    case "last":
                        int indexOfLasts = int.Parse(manipulationsCommand[1]);

                        if (indexOfLasts > myArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }

                        int[] lastElements = new int[indexOfLasts];

                        if (manipulationsCommand[2] == "even")
                        {
                            lastElements = LastEvenElements(myArray, indexOfLasts);
                        }
                        else if (manipulationsCommand[2] == "odd")
                        {
                            lastElements = LastOddElements(myArray, indexOfLasts);
                        }

                        PrintArray(lastElements);
                        break;

                    default:
                        break;
                }
            }
            PrintArray(myArray);
        }

        private static int[] LastOddElements(int[] myArray, int indexOfLasts)
        {
            int[] lastElementOdd = new int[indexOfLasts];
            int lastOddArrI = 0;

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                if (myArray[i] % 2 != 0)
                {
                    lastElementOdd[lastOddArrI++] = myArray[i];
                }
                if (lastOddArrI>=indexOfLasts)
                {
                    break;
                }
            }

            if (lastOddArrI < indexOfLasts)
            {
                lastElementOdd = ResizeArray(lastElementOdd, lastOddArrI);
            }
            lastElementOdd = ReverseArray(lastElementOdd);

            return lastElementOdd;
        }
        private static int[] LastEvenElements(int[] myArray, int indexOfLasts)
        {
            int[] lastElementEven = new int[indexOfLasts];
            int lastEvenArrI = 0;

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                if (myArray[i] % 2 == 0)
                {
                    lastElementEven[lastEvenArrI++] = myArray[i];
                }
                if (lastEvenArrI >= indexOfLasts)
                {
                    break;
                }
            }
            if (lastEvenArrI < indexOfLasts)
            {
                lastElementEven = ResizeArray(lastElementEven, lastEvenArrI);
            }
            lastElementEven = ReverseArray(lastElementEven);

            return lastElementEven;
        }
        static int[] FirstOddPrinting(int[] myArray, int index)
        {
            int[] firstElementOdd = new int[index];
            int firstOddArrI = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 != 0)
                {
                    firstElementOdd[firstOddArrI++] = myArray[i];
                }
                if (firstOddArrI>=index)
                {
                    break;
                }
            }
            if (firstOddArrI < index)
            {
                firstElementOdd = ResizeArray(firstElementOdd, firstOddArrI);
            }
            return firstElementOdd;
        }
        static int[] FirstEvenPrinting(int[] myArray, int index)
        {
            int[] firstElementOdd = new int[index];
            int firstEvenArrI = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    firstElementOdd[firstEvenArrI++] = myArray[i];
                }
                if (firstEvenArrI>=index)
                {
                    break;
                }
            }
            if (firstEvenArrI < index)
            {
                firstElementOdd = ResizeArray(firstElementOdd, firstEvenArrI);
            }

            return firstElementOdd;
        }
        static int MaxOddIndex(int[] myArray)
        {
            int maxOddIndex = -1;
            int maxOddElement = int.MinValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] >= maxOddElement && myArray[i] % 2 != 0)
                {
                    maxOddElement = myArray[i];
                    maxOddIndex = i;
                }
            }
            return maxOddIndex;
        }
        static int MaxEvenIndex(int[] myArray)
        {
            int maxEvenIndex = -1;
            int maxEvenElement = int.MinValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] >= maxEvenElement && myArray[i] % 2 == 0)
                {
                    maxEvenElement = myArray[i];
                    maxEvenIndex = i;
                }
            }

            return maxEvenIndex;
        }
        static int MinOddIndex(int[] myArray)
        {
            int minOddIndex = -1;
            int minOddElement = int.MaxValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] <= minOddElement && myArray[i] % 2 != 0)
                {
                    minOddElement = myArray[i];
                    minOddIndex = i;
                }
            }
            return minOddIndex;
        }
        static int MinEvenIndex(int[] myArray)
        {
            int minEvenIndex = -1;
            int minEvenElement = int.MaxValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] <= minEvenElement && myArray[i] % 2 == 0)
                {
                    minEvenElement = myArray[i];
                    minEvenIndex = i;
                }
            }
            return minEvenIndex;
        }
        static int[] ExchangeArray(int[] arr, int index)
        {
            int[] modifiedArr = new int[arr.Length];
            int modifiedArrIndex = 0;

            for (int i = index + 1; i < arr.Length; i++)
            {
                modifiedArr[modifiedArrIndex++] = arr[i];
            }

            for (int i = 0; i <= index; i++)
            {
                modifiedArr[modifiedArrIndex++] = arr[i];
            }

            return modifiedArr;
        }
        static void PrintArray(int[] elements)
        {
            Console.WriteLine($"[{String.Join(", ", elements)}]");
        }

        static int[] ResizeArray(int[] originalArr, int count)
        {
            int[] modifiedArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                modifiedArray[i] = originalArr[i];
            }

            return modifiedArray;
        }
        static int[] ReverseArray(int[] originalArr)
        {
            int[] reversed = new int[originalArr.Length];
            for (int i = originalArr.Length - 1; i >= 0; i--)
            {
                reversed[reversed.Length - i - 1] = originalArr[i];
            }

            return reversed;
        }
    }

}
