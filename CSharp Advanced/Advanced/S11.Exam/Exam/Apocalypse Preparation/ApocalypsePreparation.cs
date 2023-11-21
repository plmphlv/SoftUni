using System;
using System.Collections.Generic;
using System.Linq;

namespace E01.ApocalypsePreparation
{
    internal class ApocalypsePreparation
    {
        static void Main(string[] args)
        {
            Queue<int> textile = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Stack<int> meds = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Dictionary<string, int> map = MakeItems(textile, meds);

            IngredientsUsed(textile, meds);

            PrintItemsMade(map);

            IngredientsLeft(textile, meds);
        }

        private static Dictionary<string, int> MakeItems(Queue<int> textile, Stack<int> meds)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();


            while (textile.Count > 0 && meds.Count > 0)
            {
                int curRag = textile.Dequeue();
                int curMeds = meds.Pop();
                int mix = curMeds + curRag;

                if (mix >= 100)
                {
                    if (!map.ContainsKey("MedKit"))
                    {
                        map["MedKit"] = 0;
                    }

                    map["MedKit"]++;
                    mix -= 100;

                    if (mix > 0)
                    {
                        int newMed = meds.Pop() + mix;
                        meds.Push(newMed);
                    }

                }
                else if (mix == 40)
                {
                    if (!map.ContainsKey("Bandage"))
                    {
                        map["Bandage"] = 0;
                    }

                    map["Bandage"]++;
                    mix -= 40;
                }
                else if (mix == 30)
                {
                    if (!map.ContainsKey("Patch"))
                    {
                        map["Patch"] = 0;
                    }

                    map["Patch"]++;
                    mix -= 30;
                }
                else
                {
                    curMeds += 10;
                    meds.Push(curMeds);
                }
            }

            return map;
        }

        private static void IngredientsLeft(Queue<int> textile, Stack<int> meds)
        {
            if (meds.Count > 0)
            {
                Console.WriteLine($"Medicaments left: {String.Join(", ", meds)}");
            }
            if (textile.Count > 0)
            {
                Console.WriteLine($"Textiles left: {String.Join(", ", textile)}");
            }
        }

        private static void PrintItemsMade(Dictionary<string, int> map)
        {
            map = map.OrderByDescending(m => m.Value).ThenBy(m => m.Key).ToDictionary(s => s.Key, s => s.Value);

            foreach (var m in map)
            {
                Console.WriteLine($"{m.Key} - {m.Value}");
            }

            
        }

        private static void IngredientsUsed(Queue<int> textile, Stack<int> meds)
        {
            if (textile.Count == 0 && meds.Count == 0)
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
            }
            else if (textile.Count == 0)
            {
                Console.WriteLine("Textiles are empty.");
            }
            else if (meds.Count == 0)
            {
                Console.WriteLine("Medicaments are empty.");
            }
        }
    }
}