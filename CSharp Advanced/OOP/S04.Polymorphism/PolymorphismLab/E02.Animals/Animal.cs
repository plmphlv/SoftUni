namespace Animals
{
    public class Animal
    {
        private string _name;
        private string _favouriteFood;
        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public string Name { get { return _name; } protected set { _name = value; } }

        public string FavouriteFood { get { return _favouriteFood; } protected set { _favouriteFood = value; } }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }
    }
}