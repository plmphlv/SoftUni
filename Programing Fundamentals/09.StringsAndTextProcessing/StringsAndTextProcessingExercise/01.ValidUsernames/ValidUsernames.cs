using System;

namespace _01.ValidUsernames
{
    internal class ValidUsernames
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string name in usernames)
            {
                if (name.Length > 3 && name.Length <= 16)
                {
                    bool validName = true;

                    foreach (char symbol in name)
                    {
                        if (!(char.IsLetterOrDigit(symbol) || symbol == '=' || symbol == '-' || symbol == '_'))
                        {
                            validName = false;
                        }
                    }

                    if (validName)
                    {
                        Console.WriteLine(name);
                    }
                }

            }
        }
    }
}