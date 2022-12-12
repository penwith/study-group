using Common;

namespace Demos.Pizzas
{
    internal class HawaiianPizza : Pizza
    {
        public HawaiianPizza(ILogger logger) : base(logger) 
        {
            _pizzaType = "Hawaiian";
        }
    }
}
