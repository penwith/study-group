namespace ManyBeverages
{
    public abstract class Beverage
    {
        protected string _description;

        public string Description => _description;

        public abstract decimal Cost();
    }
}