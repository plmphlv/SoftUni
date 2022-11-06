using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    internal class AMinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> metals = new Dictionary<string, int>();

            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {

                int value = int.Parse(Console.ReadLine());
                if (!metals.ContainsKey(resource))
                {
                    metals[resource] = 0;
                }
                metals[resource] += value;

            }

            foreach (KeyValuePair<string, int> kvp in metals)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}