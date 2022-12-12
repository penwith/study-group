using Common;
using Demos.Pizzas;

namespace Demos
{
    public class PreDemo1 : IDemo
    {
        protected readonly ILogger _logger;

        public PreDemo1(ILogger logger)
        {
            _logger = logger;
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
            Pizza pizza = pizzaType switch
            {
                "Vegetarian" => new VegPizza(_logger),

                _ => new SomeOtherPizza(_logger)
            };

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}