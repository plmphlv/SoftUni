using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriya = double.Parse(Console.ReadLine()); // цена за килограм скумрия
            double caca = double.Parse(Console.ReadLine()); //цена за килограм цаца
            double palamud = double.Parse(Console.ReadLine()); // килограми за килограм паламуд
            double safrid = double.Parse(Console.ReadLine()); // килограм сафрид
            int clams = int.Parse(Console.ReadLine()); // килограм миди

            double cenaPalamud = (skumriya + skumriya * 0.6)*palamud;
            double cenaSafrid = (caca + caca * 0.8)* safrid;
            double cenaClams = clams * 7.50;

            double total = cenaPalamud + cenaSafrid + cenaClams;

            Console.WriteLine($"{total:f2}");
        }
    }
}
