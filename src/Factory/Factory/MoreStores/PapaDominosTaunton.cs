using Pizzas;

namespace MoreStores
{
    public class PapaDominosTaunton
    {
        public PapaDominosTaunton()
        {
            Console.WriteLine("Welcome to Taunton Papa Dominos");
        }

        private PizzaFactory _pizzaFactory = new PizzaFactory();

        public Pizza OrderPizza(string pizzaType)
        {
            var pizza = _pizzaFactory.GetPizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
