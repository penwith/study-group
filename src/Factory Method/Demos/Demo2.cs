using Common;
using Demos.Pizzas;

namespace Demos
{
    public class Demo2 : Demo
    {
        public Demo2(ILogger logger) : base(logger) { }

        protected override Pizza CreatePizza(string pizzaType)
        {
            if (pizzaType != "Vegetarian") return new SomeOtherPizza(_logger);

            return new SpicyVegPizza(_logger);
        }
    }
}
