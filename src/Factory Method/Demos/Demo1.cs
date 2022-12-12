using Common;
using Demos.Pizzas;

namespace Demos
{
    public class Demo1 : Demo
    {
        public Demo1(ILogger logger) : base(logger) { }

        protected override Pizza CreatePizza(string pizzaType)
        {
            if (pizzaType != "Vegetarian") return new SomeOtherPizza(_logger);

            return new VegPizza(_logger);
        }
    }
}