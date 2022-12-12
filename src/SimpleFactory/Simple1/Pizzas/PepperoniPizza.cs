using Common;

namespace Demos.Pizzas
{
    internal class PepperoniPizza : Pizza
    {
        public PepperoniPizza(ILogger logger) : base(logger)
        {
            _pizzaType = "Pepperoni";
        }
    }
}
