using Common;
using Demos.Pizzas;

namespace Demos
{
    public abstract class Demo : IDemo
    {
        protected readonly ILogger _logger;        

        public Demo(ILogger logger)
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
            var pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string pizzaType);
    }
}