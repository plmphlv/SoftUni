using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    internal class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> mylist = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdTokens = command.Split().ToArray();

                if (cmdTokens[0] == "Delete")
                {
                    int num = int.Parse(cmdTokens[1]);
                    mylist.RemoveAll(n => n == num);
                }
                else if (cmdTokens[0] == "Insert")
                {
                    int num = int.Parse(cmdTokens[1]);
                    int index = int.Parse(cmdTokens[2]);
                    mylist.Insert(index, num);
                }
            }

            Console.WriteLine(String.Join(" ", mylist));
        }
    }
}