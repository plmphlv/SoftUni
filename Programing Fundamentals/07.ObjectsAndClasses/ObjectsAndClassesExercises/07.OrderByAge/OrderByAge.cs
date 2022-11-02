using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    internal class OrderByAge
    {
        static void Main(string[] args)
        {
            List<Person> ledger = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);
                int id = int.Parse(cmdArgs[2]);

                Person person = ledger.FirstOrDefault(x => x.Id == id);

                if (person == null)
                {
                    person = new Person(name, age, id);
                    ledger.Add(person);
                }
                else
                {
                    person.EditPerson(name, age);
                }

            }

            List<Person> orderedList = ledger.OrderBy(x => x.Age).ToList();

            foreach (Person human in orderedList)
            {
                Console.WriteLine($"{human.Name} with ID: {human.Id} is {human.Age} years old.");
            }

        }
    }

    class Person
    {
        public Person(string name, int id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; private set; }
        public int Id { get; private set; }
        public int Age { get; private set; }

        public void EditPerson(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

}