namespace Decorators
{
    public abstract class Beverage
    {
        protected string _description = "Unknown Beverage";

        public virtual string Description => _description;

        public abstract decimal Cost();
    }
}