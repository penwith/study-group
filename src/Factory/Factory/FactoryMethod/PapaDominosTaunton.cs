using Pizzas;

namespace FactoryMethod
{
    public class PapaDominosTaunton : PizzaStore
    {
        public PapaDominosTaunton()
        {
            Console.WriteLine("Welcome to Taunton Papa Dominos");
        }

        protected override Pizza CreatePizza(string pizzaType)
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
