using FactoryMethod;

namespace Client
{
    internal class Method
    {
        public static void Run()
        {
            var bridgewaterStore = new PapaDominosBridgewater();

            var pizza = bridgewaterStore.OrderPizza("Vegetarian");

            pizza.Eat();
            Console.WriteLine();

            var tauntonStore = new PapaDominosTaunton();

            pizza = tauntonStore.OrderPizza("Vegetarian");

            pizza.Eat();
            Console.ReadKey();
        }
    }
}
