﻿using Froggy;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.Froggy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> stones = Console.ReadLine()
     .Split(", ", StringSplitOptions.RemoveEmptyEntries)
     .Select(int.Parse)
     .ToList();

            Lake lake = new(stones);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}