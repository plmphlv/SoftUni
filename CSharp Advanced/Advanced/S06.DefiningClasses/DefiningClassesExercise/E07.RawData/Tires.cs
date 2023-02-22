

namespace DefiningClasses
{
    internal class Tires
    {
        private int age;
        private double pressure;

        public Tires( double pressure,int age)
        {
            Pressure = pressure;
            Age = age;
        }

        public int Age { get { return age; } set { pressure = value; } }
        public double Pressure { get { return pressure; } set { pressure = value; } }

    }
}
