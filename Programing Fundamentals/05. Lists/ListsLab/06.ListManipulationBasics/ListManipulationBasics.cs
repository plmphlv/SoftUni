using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    internal class ListManipulationBasics
    {
        static void Main(string[] args)
        {
            List<int> myInts = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArr = command.Split().ToArray();

                if (cmdArr[0] == "Add")
                {
                    myInts.Add(int.Parse(cmdArr[1]));
                }
                else if (cmdArr[0] == "Remove")
                {
                    myInts.Remove(int.Parse(cmdArr[1]));
                }
                else if (cmdArr[0] == "RemoveAt")
                {
                    int index = int.Parse(cmdArr[1]);

                    if (index >= 0 && index < myInts.Count)
                    {
                        myInts.RemoveAt(int.Parse(cmdArr[1]));
                    }
                }
                else if (cmdArr[0] == "Insert")
                {
                    int index = int.Parse(cmdArr[2]);

                    if (index >= 0 && index < myInts.Count)
                    {
                        myInts.Insert(int.Parse(cmdArr[2]), int.Parse(cmdArr[1]));
                    }
                }
            }

            Console.WriteLine(String.Join(" ", myInts));
        }
    }
}