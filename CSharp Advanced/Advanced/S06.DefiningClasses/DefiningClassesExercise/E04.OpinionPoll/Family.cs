using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Family
    {
        private List<Person> family;

        public Family()
        {
            family = new List<Person>();
        }

        public List<Person> FamilyTree
        {
            get
            {
                return this.family;
            }
            set
            {
                this.family = value;
            }
        }

        public void AddMember(Person person)
        {
            this.family.Add(person);
        }

        public List<Person> GetFamilyList()
        {
            return family.OrderBy(x => x.Name).Where(x => x.Age > 30).ToList();
        }

        public Person GetOldestMember()
        {
            return family.OrderByDescending(m => m.Age).First();
        }

        internal List<Person> OrderBy(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
