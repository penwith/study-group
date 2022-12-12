using Common;

namespace Demos.Pizzas
{
    internal class SpicyVegPizza : Pizza
    {
        public SpicyVegPizza(ILogger logger) : base(logger)
        {
            _pizzaType = "Spicy Vegetable";
        }
    }
}
