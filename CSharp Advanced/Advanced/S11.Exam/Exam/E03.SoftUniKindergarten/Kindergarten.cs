using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        private string name;
        private int capacity;
        private List<Child> registry;

        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get { return name; } set { name = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public List<Child> Registry { get { return registry; } set { registry = value; } }
        public int ChildrenCount { get { return registry.Count; } }

        public bool AddChild(Child child)
        {
            if (registry.Count < capacity)
            {
                registry.Add(child);
                return true;
            }
            return false;
        }

        public bool RemoveChild(string childFullName)
        {
            string[] names = childFullName.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Child child = registry.FirstOrDefault(c => c.FirstName == names[0] && c.LastName == names[1]);

            if (child != null)
            {
                registry.Remove(child);
                return true;
            }

            return false;
        }

        public Child GetChild(string childFullName)
        {
            string[] names = childFullName.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return registry.FirstOrDefault(c => c.FirstName == names[0] && c.LastName == names[1]);
        }

        public string RegistryReport()
        {
            registry = registry.OrderByDescending(c => c.Age).ThenBy(c => c.LastName).ThenBy(c => c.FirstName).ToList();

            return $"Registered children in {name}:" + Environment.NewLine +
                 $"{String.Join(Environment.NewLine, registry.Select(c => $"Child: {c.FirstName} {c.LastName}, Age: {c.Age}, Contact info: {c.ParentName} - {c.ContactNumber}"))}";
        }
    }
}
