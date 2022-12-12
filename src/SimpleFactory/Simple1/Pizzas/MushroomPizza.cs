using Common;

namespace Demos.Pizzas
{
    internal class MushroomPizza : Pizza
    {
        public MushroomPizza(ILogger logger) : base(logger)
        {
            _pizzaType = "Mushroom";
        }
    }
}
