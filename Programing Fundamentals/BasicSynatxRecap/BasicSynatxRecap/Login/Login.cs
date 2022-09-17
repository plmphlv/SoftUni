using System;

namespace Login
{
    internal class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char c = username[i];
                password += username[i];
            }

            string input;
            int fails = 1;
            while ((input = Console.ReadLine()) != password)
            {

                if (fails >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    fails++;
                }
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
