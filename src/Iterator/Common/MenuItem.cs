namespace Common
{
    public class MenuItem(
        string name,
        string description,
        bool vegetarian,
        double price)
    {
        public string Name => name;

        public string Description => description;

        public bool Vegetarian => vegetarian;

        public double Price => price;
    }
}
