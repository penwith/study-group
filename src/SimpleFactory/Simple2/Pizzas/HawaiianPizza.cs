using Common;

namespace Simple2.Pizzas
{
    internal class HawaiianPizza : Pizza
    {
        public HawaiianPizza(ILogger logger) : base(logger) { }

        protected override string PizzaType { get => "Hawaiian"; }
    }
}
