using Common;

namespace Demos.Pizzas
{
    internal class VegPizza : Pizza
    {
        public VegPizza(ILogger logger) : base(logger)
        {
            _pizzaType = "Vegetable";
        }
    }
}
