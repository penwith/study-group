using Burgers;

namespace Client
{
    public static class BurgerKitchen
    {
        public static void Run()
        {
            var beefBurger = new BurgerBuilder("Granary", "8oz beef mince")
                .WithExtra("Cheese")
                .WithExtra("Pickle")
                .WithSide("Fries")
                .Build();

            beefBurger.Eat();

            var veggieBurger = BurgerBuilder
                .Init("Wholemeal", "Spicy potato and cauliflower")
                .WithExtra("Halloumi")
                .WithExtra("Red onion")
                .WithSide("Coleslaw")
                .Build();

            veggieBurger.Eat();

            var budgetBurger = BurgerBuilder
                .Init("Plain white bun", "6ox value patty")
                .Build();

            budgetBurger.Eat();

            Console.ReadKey();
        }
    }
}
