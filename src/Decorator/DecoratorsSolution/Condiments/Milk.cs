namespace Decorators.Condiments
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => $"{_beverage.Description}, Milk";

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.30M;
        }
    }
}
