namespace Burgers
{
    public static class SetMenuBurgerBuilder
    {
        public static Burger BuildVeggie()
        {
            return BurgerBuilder
                .Init("Ciabatta roll", "Spicy mexican bean burger")
                .WithExtra("Gherkin")
                .WithExtra("Seared halloumi")
                .WithExtra("Red onion")
                .WithExtra("Mayo")
                .WithSide("Sweet potato fries")
                .WithSide("Mixed leaf tomato salad")
                .Build();
        }

        public static Burger BuildGourmet()
        {
            return BurgerBuilder
                .Init("Brioche bun", "12oz organic steak mince")
                .WithExtra("Mature cheddar cheese")
                .WithExtra("Smoked back bacon")
                .WithExtra("Pickle")
                .WithExtra("Sweet chilli sauce")
                .WithSide("Chunky chips")
                .WithSide("Coleslaw")
                .Build();
        }
    }
}
