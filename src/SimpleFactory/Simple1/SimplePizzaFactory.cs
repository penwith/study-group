using Common;
using Demos.Pizzas;

namespace Demos
{
    public class SimplePizzaFactory : IPizzaFactory
    {
        private readonly ILogger _logger;

        public SimplePizzaFactory(ILogger logger)
        {
            _logger = logger;
        }

        public Pizza CreatePizza(string pizzaType)
        {
            return pizzaType switch
            {
                "Vegetarian" => new VegPizza(_logger),
                "Pepperoni" => new PepperoniPizza(_logger),
                "Hawaiian" => new HawaiianPizza(_logger),

                _ => throw new ArgumentOutOfRangeException(nameof(pizzaType)),
            };
        }
    }
}
