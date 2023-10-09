namespace Pizzas
{
    public class VegPizzaSupreme : Pizza
    {
        public VegPizzaSupreme()
        {
            _pizzaType = "Vegetable";

            _toppings.Add("Onions");
            _toppings.Add("Peppers");
            _toppings.Add("Turnips");
        }
    }
}
