using Common;

namespace Demos.Pizzas
{
    public class SomeOtherPizza : Pizza
    {
        public SomeOtherPizza(ILogger logger) : base(logger)
        {
            _pizzaType = "Unknown";
        }
    }
}
