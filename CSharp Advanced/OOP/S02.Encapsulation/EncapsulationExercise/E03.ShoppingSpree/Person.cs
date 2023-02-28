using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03.ShoppingSpree
{
    internal class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person()
        {
            
        }

        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<Product> Bag { get; set; }


    }
}
