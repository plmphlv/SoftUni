

namespace DefiningClasses
{
    internal class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Speed { get { return speed; } set { power = value; } }
        public int Power { get { return power; } set { power = value; } }
    }
}
