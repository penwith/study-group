using Common;

namespace Simple2.Pizzas
{
    internal class PepperoniPizza : Pizza
    {
        public PepperoniPizza(ILogger logger) : base(logger) { }

        protected override string PizzaType { get => "Pepperoni"; }
    }
}
