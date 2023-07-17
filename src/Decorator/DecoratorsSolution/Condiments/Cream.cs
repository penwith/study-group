namespace Decorators.Condiments
{
    public class Cream : CondimentDecorator
    {
        public Cream(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => $"{_beverage.Description}, Cream";

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.70M;
        }
    }
}
