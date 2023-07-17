namespace Condiments
{
    public class Beverage
    {
        protected string _description;

        public string Description => _description;

        public virtual decimal Cost()
        {
            var cost = 0M;

            if (HasMilk) cost += 0.30M;
            if (HasSoya) cost += 0.50M;
            if (HasMocha) cost += 0.60M;
            if (HasCream) cost += 0.70M;

            return cost;
        }

        public bool HasMilk { get; set; }
        public bool HasSoya { get; set; }
        public bool HasMocha { get; set; }
        public bool HasCream { get; set; }
    }
}