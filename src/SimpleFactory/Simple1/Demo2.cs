using Common;
using Demos.Pizzas;

namespace Demos
{
    public class Demo2 : IDemo
    {
        private readonly ILogger _logger;
        private readonly SimplePizzaFactory _pizzaFactory;

        public Demo2(ILogger logger, SimplePizzaFactory pizzaFactory)
        {
            _logger = logger;
            _pizzaFactory = pizzaFactory;
        }

        public async Task Process()
        {
            _logger.LogInfo("Ordering a pizza...");

            try
            {
                await OrderPizza("Vegetarian").Eat();
            }
            catch (InedibleException ex)
            {
                _logger.LogError($"Pizza was inedible - {ex.Message}");
            }            
        }

        private Pizza OrderPizza(string pizzaType)
        {
            var pizza = _pizzaFactory.CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}