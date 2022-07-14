using System;

namespace FruitOrVeggie
{
    internal class FruitOrVeggie
    {
        static void Main(string[] args)
        {
            string produse = Console.ReadLine();

            switch (produse)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break ;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
