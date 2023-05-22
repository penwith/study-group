namespace Sandpit
{
    public class Coffee : Beverage
    {
        public override void Prepare()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        private void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        private void AddSugarAndMilk()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
