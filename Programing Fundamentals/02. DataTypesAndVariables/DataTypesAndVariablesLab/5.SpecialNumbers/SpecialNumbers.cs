namespace _5.SpecialNumbers
{
    internal class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int digit = 0;
                int sum = 0;
                int num = i;

                while (!(num <= 0))
                {
                    digit = num % 10;
                    num /= 10;
                    sum += digit;
                }

                if (sum == 5 || sum == 7 || sum == 10)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}