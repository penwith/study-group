using Pizzas;

namespace SimplePizzaStore
{
    public class PapaDominos
    {
        public PapaDominos()
        {
            Console.WriteLine("Welcome to Papa Dominos");
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
