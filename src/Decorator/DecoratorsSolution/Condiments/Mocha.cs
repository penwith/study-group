namespace Decorators.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => $"{_beverage.Description}, Mocha";

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.60M;
        }
    }
}
