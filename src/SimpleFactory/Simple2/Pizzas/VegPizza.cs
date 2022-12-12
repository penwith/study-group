using Common;

namespace Simple2.Pizzas
{
    internal class VegPizza : Pizza
    {
        public VegPizza(ILogger logger) : base(logger) { }

        protected override string PizzaType { get => "Vegetable"; }
    }
}
