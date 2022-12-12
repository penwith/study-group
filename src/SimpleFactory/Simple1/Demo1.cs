using Common;
using Demos.Pizzas;

namespace Demos
{
    public class Demo1 : IDemo
    {
        private readonly ILogger _logger;

        public Demo1(ILogger logger)
        {
            _logger = logger;
        }

        public async Task Process()
        {
            _logger.LogInfo("Ordering a pizza...");

            try
            {
                await OrderPizza("Mushroom").Eat();
            }
            catch (InedibleException ex)
            {
                _logger.LogError($"Pizza was inedible - {ex.Message}");
            }            
        }

        private Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = pizzaType switch
            {
                "Vegetarian" => new VegPizza(_logger),
                "Pepperoni" => new PepperoniPizza(_logger),
                "Hawaiian" => new HawaiianPizza(_logger),
                "Mushroom" => new MushroomPizza(_logger),

                _ => throw new ArgumentOutOfRangeException(nameof(pizzaType)),
            };

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}