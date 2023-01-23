using Burgers;

namespace Client
{
    public static class BurgerBar
    {
        public static void Run()
        {
            SetMenuBurgerBuilder.BuildVeggie().Eat();
            SetMenuBurgerBuilder.BuildGourmet().Eat();

            Console.ReadKey();
        }
    }
}
