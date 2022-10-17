using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    internal class ListManipulationAdvanced
    {
        static void Main(string[] args)
        {
            List<int> myInts = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            bool listHasBeenChanged=false;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArr = command.Split().ToArray();

                if (cmdArr[0] == "Add")
                {

                    myInts.Add(int.Parse(cmdArr[1]));
                    listHasBeenChanged = true;

                }
                else if (cmdArr[0] == "Remove")
                {

                    myInts.Remove(int.Parse(cmdArr[1]));
                    listHasBeenChanged = true;

                }
                else if (cmdArr[0] == "RemoveAt")
                {

                    int index = int.Parse(cmdArr[1]);

                    if (index >= 0 && index < myInts.Count)
                    {
                        myInts.RemoveAt(int.Parse(cmdArr[1]));
                        listHasBeenChanged = true;
                    }

                }
                else if (cmdArr[0] == "Insert")
                {

                    int index = int.Parse(cmdArr[2]);

                    if (index >= 0 && index < myInts.Count)
                    {

                        myInts.Insert(int.Parse(cmdArr[2]), int.Parse(cmdArr[1]));
                        listHasBeenChanged = true;

                    }

                }
                else if (cmdArr[0] == "Contains")
                {

                    if (myInts.Contains(int.Parse(cmdArr[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }

                }
                else if (cmdArr[0] == "PrintEven")
                {

                    foreach (int i in myInts)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine();

                }
                else if (cmdArr[0] == "PrintOdd")
                {

                    foreach (int i in myInts)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine();

                }
                else if (cmdArr[0] == "GetSum")
                {

                    Console.WriteLine(myInts.Sum());

                }
                else if (cmdArr[0] == "Filter")
                {
                    int conditionNum=int.Parse(cmdArr[2]);

                    if (cmdArr[1]==">")
                    {

                        foreach (int i in myInts)
                        {
                            if (i > conditionNum)
                            {
                                Console.Write(i + " ");
                            }
                        }
                        Console.WriteLine();

                    }
                    else if (cmdArr[1]=="<")
                    {

                        foreach (int i in myInts)
                        {
                            if (i < conditionNum)
                            {
                                Console.Write(i + " ");
                            }
                        }
                        Console.WriteLine();

                    }
                    else if (cmdArr[1]==">=")
                    {

                        foreach (int i in myInts)
                        {
                            if (i >= conditionNum)
                            {
                                Console.Write(i + " ");
                            }
                        }
                        Console.WriteLine();

                    }
                    else if (cmdArr[1]=="<=")
                    {

                        foreach (int i in myInts)
                        {
                            if (i <= conditionNum)
                            {
                                Console.Write(i + " ");
                            }
                        }
                        Console.WriteLine();

                    }

                }
            }

            if (listHasBeenChanged)
            {
                Console.WriteLine(String.Join(" ", myInts));
            }
        }
    }
}