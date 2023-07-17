namespace Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage _beverage;

        public abstract override string Description { get; }
    }
}
