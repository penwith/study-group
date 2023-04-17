namespace TemplateMethod
{
    public class Tea
    {
        public void Prepare()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        private void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
