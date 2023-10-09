namespace Pizzas
{
    public class VegPizza : Pizza
    {
        public VegPizza()
        {
            _pizzaType = "Vegetable";

            _toppings.Add("Onions");
            _toppings.Add("Peppers");
            _toppings.Add("Sweetcorn");
        }
    }
}
