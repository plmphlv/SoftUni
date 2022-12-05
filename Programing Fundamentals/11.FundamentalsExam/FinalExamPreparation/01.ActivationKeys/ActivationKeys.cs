using System;
using System.Text;

namespace _01.ActivationKeys
{
    internal class ActivationKeys
    {
        static void Main(string[] args)
        {
            string productKey = Console.ReadLine();
            StringBuilder keyEditor = new StringBuilder();

            keyEditor.Append(productKey);

            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] cmdArgs = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string task = cmdArgs[0];

                switch (task)
                {
                    case "Contains":

                        string substring = cmdArgs[1];

                        if (keyEditor.ToString().Contains(substring))
                        {
                            Console.WriteLine($"{keyEditor} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }

                        break;
                    case "Flip":

                        int strtingStartingIndex = int.Parse(cmdArgs[2]);
                        int strtingEndIndex = int.Parse(cmdArgs[3]);

                        string substringToFlip = keyEditor.ToString().Substring(strtingStartingIndex, strtingEndIndex - strtingStartingIndex);
                        string flipedSub = string.Empty;

                        string flipType = cmdArgs[1];
                        if (flipType == "Upper")
                        {
                            flipedSub = substringToFlip.ToUpper();
                        }
                        else if (flipType == "Lower")
                        {
                            flipedSub = substringToFlip.ToLower();
                        }

                        keyEditor.Replace(substringToFlip, flipedSub);

                        Console.WriteLine(keyEditor);

                        break;
                    case "Slice":

                        int stringStartingIndex = int.Parse(cmdArgs[1]);
                        int stringEndIndex = int.Parse(cmdArgs[2]);

                        keyEditor.Remove(stringStartingIndex, stringEndIndex - stringStartingIndex);

                        Console.WriteLine(keyEditor);

                        break;
                }


            }

            Console.WriteLine($"Your activation key is: {keyEditor}");
        }
    }
}