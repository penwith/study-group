using Common;
using Demos.Pizzas;

namespace Demos
{
    public enum DemoType
    {
        Demo1,
        Demo2
    }

    public class PreDemo2 : IDemo
    {
        protected readonly ILogger _logger;
        private DemoType Demo => DemoType.Demo2;

        public PreDemo2(ILogger logger)
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
            Pizza pizza = null;

            if (Demo == DemoType.Demo1)
            {
                if (pizzaType == "Vegetarian")
                    pizza = new VegPizza(_logger);
            }
            else if (Demo == DemoType.Demo2)
            {
                if (pizzaType == "Vegetarian")
                    pizza = new SpicyVegPizza(_logger);
            }
            else
            {
                _logger.LogError("Whoops");
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }        
    }
}