namespace Pizzas
{
    public abstract class Pizza
    {
        protected string _pizzaType = string.Empty;
        protected List<string> _toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing {_pizzaType} pizza");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");

            _toppings.ForEach(t => Console.WriteLine($"- {t} topping"));
        }

        public void Bake()
        {
            Console.WriteLine("Baking for 10 mins at 180 degrees");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting into slices");
        }

        public void Box()
        {
            Console.WriteLine("Putting into box");
        }

        public void Eat()
        {
            Console.WriteLine("Mmmmmm... Pizza!");
        }
    }
}
