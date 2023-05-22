namespace Sandpit
{
    public abstract class Beverage
    {
        public abstract void Prepare();

        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
