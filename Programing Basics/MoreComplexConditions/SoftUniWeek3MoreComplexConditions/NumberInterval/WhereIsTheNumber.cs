﻿using System;

namespace NumberInterval
{
    internal class WhereIsTheNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= -100 && number <= 100 && number != 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
