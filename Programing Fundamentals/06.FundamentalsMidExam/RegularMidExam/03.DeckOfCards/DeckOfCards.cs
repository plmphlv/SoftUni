using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.DeckOfCards
{
    internal class DeckOfCards
    {
        static void Main(string[] args)
        {
            List<string> deck = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int numOfCmd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numOfCmd; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (cmdArgs[0])
                {
                    case "Add":

                        if (!deck.Contains(cmdArgs[1]))
                        {
                            deck.Add(cmdArgs[1]);
                            Console.WriteLine("Card successfully added");
                        }
                        else
                        {
                            Console.WriteLine("Card is already in the deck");
                        }

                        break;
                    case "Remove":

                        if (deck.Contains(cmdArgs[1]))
                        {
                            deck.Remove(cmdArgs[1]);
                            Console.WriteLine("Card successfully removed");
                        }
                        else
                        {
                            Console.WriteLine("Card not found");
                        }

                        break;
                    case "Remove At":

                        int removeIndex = int.Parse(cmdArgs[1]);

                        if (removeIndex >= 0 && removeIndex < deck.Count)
                        {
                            deck.RemoveAt(removeIndex);
                            Console.WriteLine("Card successfully removed");
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }

                        break;
                    case "Insert":

                        int insertIndex = int.Parse(cmdArgs[1]);

                        if (!(insertIndex >= 0 && insertIndex < deck.Count))
                        {
                            Console.WriteLine("Index out of range");
                        }
                        else if (deck.Contains(cmdArgs[2]))
                        {
                            Console.WriteLine("Card is already added");
                        }
                        else
                        {
                            deck.Insert(insertIndex, cmdArgs[2]);
                            Console.WriteLine("Card successfully added");
                        }

                        break;
                }

            }

            Console.WriteLine(String.Join(", ", deck));
        }
    }
}