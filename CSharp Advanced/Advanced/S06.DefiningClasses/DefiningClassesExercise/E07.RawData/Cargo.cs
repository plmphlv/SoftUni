using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Cargo
    {
        private string type;
        private double weight;

        public Cargo(string type, double weight)
        {
            TypeOfCargo = type;
            Weight = weight;
        }

        public string TypeOfCargo { get { return type; } set { type = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
    }
}
