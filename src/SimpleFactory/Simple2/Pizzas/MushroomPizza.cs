using Common;

namespace Simple2.Pizzas
{
    internal class MushroomPizza : Pizza
    {
        public MushroomPizza(ILogger logger) : base(logger) { }

        protected override string PizzaType { get => "Mushroom"; }
    }
}
