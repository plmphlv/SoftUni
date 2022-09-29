using System;

namespace _10.Pokemon
{
    internal class Pokemon
    {
        static void Main(string[] args)
        {
            uint pokemonN = uint.Parse(Console.ReadLine());
            uint pokemonM = uint.Parse(Console.ReadLine());
            uint pokemonY = uint.Parse(Console.ReadLine());

            double pokePower = pokemonN * 0.5;

            uint nOriginalValue = pokemonN;
            int pokes = 0;

            while (pokemonN >= pokemonM)
            {
                pokemonN -= pokemonM;
                pokes++;

                if (pokemonN == pokePower && pokemonY != 0)
                {
                    pokemonN /= pokemonY;
                }
            }

            Console.WriteLine(pokemonN);
            Console.WriteLine(pokes);
        }
    }
}