using System;
using System.Linq;

namespace _02.CoffeeLover
{
    internal class CoffeeLover
    {
        static void Main(string[] args)
        {
            string[] coffeList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            int numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] coffeListDupe;
                switch (cmdArgs[0])
                {
                    case "Include":

                        coffeListDupe = new string[coffeList.Length + 1];

                        for (int j = 0; j < coffeList.Length; j++)
                        {
                            coffeListDupe[j] = coffeList[j];
                        }

                        coffeListDupe[coffeListDupe.Length - 1] = cmdArgs[1];
                        coffeList = coffeListDupe;

                        break;
                    case "Remove":

                        int numOfCoffees = int.Parse(cmdArgs[2]);

                        if (numOfCoffees <= coffeList.Length && numOfCoffees > 0)
                        {
                            coffeListDupe = new string[coffeList.Length - numOfCoffees];

                            if (cmdArgs[1] == "first")
                            {
                                //int kli = 0;
                                for (int j = numOfCoffees; j < coffeList.Length; j++)
                                {
                                    //coffeListDupe[kli] = coffeList[j];
                                    coffeListDupe[j - numOfCoffees] = coffeList[j];
                                    //kli++;

                                }
                                coffeList = coffeListDupe;
                            }
                            else if (cmdArgs[1] == "last")
                            {

                                for (int j = 0; j < coffeList.Length - numOfCoffees; j++)
                                {
                                    coffeListDupe[j] = coffeList[j];
                                }
                                coffeList = coffeListDupe;
                            }
                        }

                        break;
                    case "Prefer":

                        int coffe1To2 = int.Parse(cmdArgs[1]);
                        int coffe2To1 = int.Parse(cmdArgs[2]);
                        string buffer = string.Empty;

                        if ((coffe1To2 >= 0 && coffe1To2 < coffeList.Length) && (coffe2To1 >= 0 && coffe2To1 < coffeList.Length))
                        {
                            buffer = coffeList[coffe1To2];
                            coffeList[coffe1To2] = coffeList[coffe2To1];
                            coffeList[coffe2To1] = buffer;
                        }

                        break;
                    case "Reverse":

                        string ListDupe = string.Join(" ", coffeList).ToString();
                        coffeList = ListDupe.Split().Reverse().ToArray();

                        break;
                }


            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffeList));
        }
    }
}
