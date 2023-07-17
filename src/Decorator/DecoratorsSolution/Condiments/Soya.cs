namespace Decorators.Condiments
{
    public class Soya : CondimentDecorator
    {
        public Soya(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => $"{_beverage.Description}, Soya";

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.50M;
        }
    }
}
