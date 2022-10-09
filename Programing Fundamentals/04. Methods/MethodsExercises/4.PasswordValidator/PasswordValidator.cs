using System;

namespace _4.PasswordValidator
{
    internal class PasswordValidator
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isLongEnough = PasswordLenghtCheck(password);
            bool isOnlyNumbersAndLetters = PasswordIsAlphaNumeric(password);
            bool containsAtLeastTwoDigits = NumberCountInPassword(password);

            if (!isLongEnough)
                Console.WriteLine("Password must be between 6 and 10 characters");

            if (!isOnlyNumbersAndLetters)
                Console.WriteLine("Password must consist only of letters and digits");

            if (!containsAtLeastTwoDigits)
                Console.WriteLine("Password must have at least 2 digits");

            if (isLongEnough && isOnlyNumbersAndLetters && containsAtLeastTwoDigits)
                Console.WriteLine("Password is valid");

        }

        static bool PasswordLenghtCheck(string word)
        {
            return (word.Length >= 6 && word.Length <= 10) ? true : false;
        }

        static bool PasswordIsAlphaNumeric(string word)
        {
            foreach (char c in word)
            {
                if (!(Char.IsLetterOrDigit(c)))
                {
                    return false;
                }
            }
            return true;
        }

        static bool NumberCountInPassword(string word)
        {
            int numbersInPassword = 0;
            foreach (char c in word)
            {
                if (Char.IsDigit(c))
                {
                    numbersInPassword++;
                }
            }
            return (numbersInPassword >= 2) ? true : false;
        }
    }
}