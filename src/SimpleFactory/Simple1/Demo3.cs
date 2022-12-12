using Common;
using Demos.Pizzas;

namespace Demos
{
    public class Demo3 : IDemo
    {
        private readonly ILogger _logger;
        private readonly IPizzaFactory _pizzaFactory;

        public Demo3(ILogger logger, IPizzaFactory pizzaFactory)
        {
            _logger = logger;
            _pizzaFactory = pizzaFactory;
        }

        public async Task Process()
        {
            _logger.LogInfo("Ordering a pizza...");

            try
            {
                await OrderPizza("Sweetcorn").Eat();
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
