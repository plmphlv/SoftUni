using System;

namespace PasswordChecker
{
    class Password
    {
        static void Main(string[] args)
        {
            string password = "s3cr3t!P@ssw0rd";
            string passwordInput = Console.ReadLine();
            if (password==passwordInput)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
