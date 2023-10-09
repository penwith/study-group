using Pizzas;

namespace FactoryMethod
{
    public class PapaDominosBridgewater : PizzaStore
    {
        public PapaDominosBridgewater()
        {
            Console.WriteLine("Welcome to Bridgewater Papa Dominos (we're so much better than Taunton)");
        }

        protected override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = pizzaType switch
            {
                "Vegetarian" => new VegPizzaSupreme(),
                "Pepperoni" => new PepperoniPizza(),
                "Hawaiian" => new HawaiianPizza(),
                "Mushroom" => new MushroomPizza(),
                "Chicken" => new ChickenPizza(),
                "Mighty" => new MightyMeatyPizza(),

                _ => throw new ArgumentOutOfRangeException(nameof(pizzaType)),
            };

            return pizza;
        }
    }
}
