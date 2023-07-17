namespace Condiments
{
    public class Beverage
    {
        protected string _description;

        public string Description => _description;

        public virtual decimal Cost() => 0M;
    }
}