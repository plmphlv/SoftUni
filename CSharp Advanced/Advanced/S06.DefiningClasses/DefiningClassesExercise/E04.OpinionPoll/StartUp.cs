using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfMembers = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberOfMembers; i++)
            {
                string[] member = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                family.AddMember(new Person(member[0], int.Parse(member[1])));
            }



            Console.WriteLine(String.Join(Environment.NewLine, family.GetFamilyList().Select(x => $"{x.Name} - {x.Age}")));
        }
    }
}