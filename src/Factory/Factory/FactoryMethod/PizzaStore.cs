using Pizzas;

namespace FactoryMethod
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string pizzaType)
        {
            var pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string pizzaType);
    }
}
