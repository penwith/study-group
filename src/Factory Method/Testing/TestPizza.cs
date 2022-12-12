using Common;
using Demos;
using Demos.Pizzas;
using System.Threading.Tasks;

namespace Testing
{
    internal class TestPizza : Pizza
    {
        public TestPizza(ILogger logger) : base(logger) 
        {
            _pizzaType = "Turnip";
        }

        public override async Task Eat()
        {
            throw new InedibleException("Blerg... Turnips!");
        }
    }
}
