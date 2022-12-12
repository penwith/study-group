using Common;
using Simple2.Pizzas;

namespace Simple2
{
    public class Demo : IDemo
    {
        private readonly ILogger _logger;
        private readonly SimplePizzaFactory _pizzaFactory;

        public Demo(ILogger logger, SimplePizzaFactory pizzaFactory)
        {
            _logger = logger;
            _pizzaFactory = pizzaFactory;
        }

        public async Task Process()
        {
            _logger.LogInfo("Ordering a pizza...");

            try
            {
                await OrderPizza("Mushroom").Eat();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
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