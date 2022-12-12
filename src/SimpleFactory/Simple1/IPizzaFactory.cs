using Demos.Pizzas;

namespace Demos
{
    public interface IPizzaFactory
    {
        Pizza CreatePizza(string pizzaType);
    }
}
