using Common;

namespace Simple2.Pizzas
{
    internal abstract class Pizza
    {
        private readonly ILogger _logger;

        public Pizza(ILogger logger)
        {
            _logger = logger;
        }

        protected abstract string PizzaType { get; }

        public void Prepare()
        {
            _logger.LogInfo($"Preparing {PizzaType} pizza");
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

        public async Task Eat()
        {
            _logger.LogInfo("Mmmmmm... Pizza!");

            return;
        }
    }
}
