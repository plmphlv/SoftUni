using System;

namespace ReportSystem
{
    internal class ReportSystem
    {
        static void Main(string[] args)
        {
            int donationGoal = int.Parse(Console.ReadLine());
            string command;
            int transactionLine = 1;
            int cashPayCount = 0;
            double cashPaySum = 0;
            int applePayCount = 0;
            double applePaySum = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                int money = int.Parse(command);
                if (transactionLine % 2 == 0) // card payments(applePay)
                {
                    if (money < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        applePayCount++;
                        applePaySum += money;
                    }
                }
                else //cash payments(cashPay)
                {
                    if (money > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        cashPayCount++;
                        cashPaySum += money;
                    }
                }
                transactionLine++;
                if (cashPaySum + applePaySum >= donationGoal)
                {
                    Console.WriteLine($"Average CS: {cashPaySum / cashPayCount:f2}");
                    Console.WriteLine($"Average CC: {applePaySum / applePayCount:f2}");
                    return;
                }
            }
            Console.WriteLine("Failed to collect required money for charity.");
        }
    }
}
