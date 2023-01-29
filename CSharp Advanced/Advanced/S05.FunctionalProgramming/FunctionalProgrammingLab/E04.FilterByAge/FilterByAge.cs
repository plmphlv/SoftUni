using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.FilterByAge
{
    internal class FilterByAge
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            List<Person> list = new List<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(cmdArg[0], int.Parse(cmdArg[1]));

                list.Add(person);
            }

            string ageCondition = Console.ReadLine();
            int ageLimit = int.Parse(Console.ReadLine());
            Action<Person> printPerson = GetPrintStyle(Console.ReadLine());

            Func<Person, bool> ageFilter = GetAgeFilter(ageCondition, ageLimit);

            List<Person> sorted = list.Where(x => ageFilter(x)).ToList();

            foreach (Person person in sorted)
            {
                printPerson(person);
            }
        }

        private static Action<Person> GetPrintStyle(string style)
        {
            if (style == "name")
            {
                return x => Console.WriteLine($"{x.Name}");
            }
            else if (style == "age")
            {
                return x => Console.WriteLine($"{x.Age}");
            }
            else if (style == "name age")
            {
                return x => Console.WriteLine($"{x.Name} - {x.Age}");
            }
            return null;
        }


        private static Func<Person, bool> GetAgeFilter(string condition, int age)
        {
            if (condition == "younger")
            {
                return x => x.Age < age;
            }
            else
            {
                return x => x.Age >= age;
            }
        }

        class Person
        {
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}