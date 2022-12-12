using Common;
using Simple2.Pizzas;

namespace Simple2
{
    public class SimplePizzaFactory
    {
        private readonly ILogger _logger;

        public SimplePizzaFactory(ILogger logger)
        {
            _logger = logger;
        }

        internal Pizza CreatePizza(string pizzaType)
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
