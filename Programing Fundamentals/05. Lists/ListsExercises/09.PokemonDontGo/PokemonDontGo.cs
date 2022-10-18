using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDontGo
{
    internal class PokemonDontGo
    {
        static void Main(string[] args)
        {
            List<int> pokemon = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sumOfPokemon = 0;

            while (pokemon.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int number;

                if (index < 0)
                {
                    number = pokemon[0];
                    pokemon.RemoveAt(0);
                    pokemon.Insert(0, pokemon[pokemon.Count - 1]);

                }
                else if (index >= pokemon.Count)
                {
                    number = pokemon[pokemon.Count - 1];
                    pokemon.RemoveAt(pokemon.Count - 1);
                    pokemon.Add(pokemon[0]);
                }
                else
                {
                    number = pokemon[index];
                    pokemon.RemoveAt(index);
                }

                sumOfPokemon += number;

                for (int i = 0; i < pokemon.Count; i++)
                {
                    if (number >= pokemon[i])
                    {
                        pokemon[i] += number;
                    }
                    else if (number < pokemon[i])
                    {
                        pokemon[i] -= number;
                    }
                }
            }
            Console.WriteLine(sumOfPokemon);
        }
    }
}