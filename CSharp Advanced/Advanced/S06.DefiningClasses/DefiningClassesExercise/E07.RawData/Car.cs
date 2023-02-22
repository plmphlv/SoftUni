using DefiningClasses;


namespace E07.RawData
{
    internal class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tires[] tires;

        public Car(string model, Engine engine, Cargo cargo, Tires[] tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }

        public string Model { get { return model; } set { model = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public Cargo Cargo { get { return cargo; } set { cargo = value; } }
        public Tires[] Tires { get { return tires; } set { tires = value; } }

    }
}
