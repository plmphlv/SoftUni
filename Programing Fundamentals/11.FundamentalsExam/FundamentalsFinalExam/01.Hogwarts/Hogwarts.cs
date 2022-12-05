using System;
using System.Text;

namespace _01.Hogwarts
{
    internal class Hogwarts
    {
        static void Main(string[] args)
        {

            string spell = Console.ReadLine();

            StringBuilder spellEditor = new StringBuilder();
            spellEditor.Append(spell);

            string commandLine;
            while ((commandLine = Console.ReadLine()) != "Abracadabra")
            {
                string[] cmdArgs = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];

                switch (command)
                {
                    case "Abjuration":

                        spell = spell.ToUpper();
                        spellEditor.Clear();
                        spellEditor.Append(spell);
                        Console.WriteLine(spellEditor);

                        break;
                    case "Necromancy":

                        spell = spell.ToLower();
                        spellEditor.Clear();
                        spellEditor.Append(spell);
                        Console.WriteLine(spellEditor);

                        break;
                    case "Illusion":

                        int index = int.Parse(cmdArgs[1]);
                        char letterForReplacement = char.Parse(cmdArgs[2]);


                        if (index >= 0 && index < spellEditor.Length)
                        {

                            char[] spellArray = spellEditor.ToString().ToCharArray();
                            spellArray[index] = letterForReplacement;

                            spell = string.Join("", spellArray);
                            spellEditor.Clear();
                            spellEditor.Append(spell);

                            Console.WriteLine("Done!");
                        }
                        else
                        {
                            Console.WriteLine("The spell was too weak.");
                        }


                        break;
                    case "Divination":

                        string oldSubString = cmdArgs[1];
                        string newSubString = cmdArgs[2];

                        if (spellEditor.ToString().Contains(oldSubString))
                        {
                            spellEditor.Replace(oldSubString, newSubString);
                            Console.WriteLine(spellEditor);
                        }

                        break;
                    case "Alteration":

                        string partForRemoval = cmdArgs[1];

                        if (spellEditor.ToString().Contains(partForRemoval))
                        {
                            int indexForRemola = spellEditor.ToString().IndexOf(partForRemoval);

                            spellEditor.Remove(indexForRemola, partForRemoval.Length);
                            Console.WriteLine(spellEditor);
                        }

                        break;
                    default:
                        Console.WriteLine("The spell did not work!");
                        break;
                }

                spell = spellEditor.ToString();


            }



        }
    }
}