using Pizzas;

namespace MoreStores
{
    public class PizzaFactory
    {
        public Pizza GetPizza(string pizzaType)
        {
            Pizza pizza = pizzaType switch
            {
                "Vegetarian" => new VegPizza(),
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
