using Common;

namespace Demos.Pizzas
{
    public abstract class Pizza
    {
        protected readonly ILogger _logger;
        protected string _pizzaType = string.Empty;

        public Pizza(ILogger logger)
        {
            _logger = logger;
        }

        public void Prepare()
        {
            _logger.LogInfo($"Preparing {_pizzaType} pizza");
            _logger.LogInfo("Tossing dough...");
            _logger.LogInfo("Adding sauce...");
            _logger.LogInfo("Adding toppings...");
        }

        public void Bake()
        {
            _logger.LogInfo("Baking for 10 mins at 100 degrees");
        }

        public void Cut()
        {
            _logger.LogInfo("Cutting into slices");
        }

        public void Box()
        {
            _logger.LogInfo("Putting into box");
        }

        public virtual async Task Eat()
        {
            _logger.LogInfo("Mmmmmm... Pizza!");

            return;
        }
    }
}
