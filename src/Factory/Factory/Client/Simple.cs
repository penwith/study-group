using SimplePizzaStore;

namespace Client
{
    internal static class Simple
    {
        public static void Run()
        {
            var store = new PapaDominos();

            var pizza = store.OrderPizza("Vegetarian");

            pizza.Eat();

            Console.ReadKey();
        }
    }
}
