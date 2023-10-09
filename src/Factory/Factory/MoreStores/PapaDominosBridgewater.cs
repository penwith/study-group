using Pizzas;

namespace MoreStores
{
    public class PapaDominosBridgewater
    {
        public PapaDominosBridgewater()
        {
            Console.WriteLine("Welcome to Bridgewater Papa Dominos");
        }

        private PizzaFactory _pizzaFactory = new PizzaFactory();

        public Pizza OrderPizza(string pizzaType)
        {
            var pizza = _pizzaFactory.GetPizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            Console.WriteLine("Pssst! - here's a discount voucher for your next order.");
            Console.WriteLine("Come here instead of Taunton next time, we are waaay better.");
            Console.WriteLine("Bwa ha ha ha ha..... ");

            return pizza;
        }
    }
}
