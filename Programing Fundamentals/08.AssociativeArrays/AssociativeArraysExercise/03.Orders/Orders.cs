using System;
using System.Collections.Generic;

namespace _03.Orders
{
    internal class Orders
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> drinksPrice = new Dictionary<string, double>();
            Dictionary<string, int> drinksQuantity = new Dictionary<string, int>();

            string command;
            while ((command = Console.ReadLine()) != "buy")
            {

                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string drink = cmdArgs[0];
                double price = double.Parse(cmdArgs[1]);
                int quantity = int.Parse(cmdArgs[2]);


                if (!drinksPrice.ContainsKey(drink) && !drinksQuantity.ContainsKey(drink))
                {

                    drinksPrice[drink] = price;
                    drinksQuantity[drink] = 0;

                }

                drinksQuantity[drink]+=quantity;

            }

            foreach (KeyValuePair<string, int> pair in drinksQuantity)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value * drinksPrice[pair.Key]:f2}");
            }


        }
    }
}