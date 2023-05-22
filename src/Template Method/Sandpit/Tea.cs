namespace Sandpit
{
    public class Tea : Beverage
    {
        public override void Prepare()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        private void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

        private void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
