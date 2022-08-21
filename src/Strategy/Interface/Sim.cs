namespace Interface
{
    public class Sim
    {
        public void Run()
        {
            var ducks = new List<Duck>
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new DecoyDuck()
            };

            ducks.ForEach(d =>
            {
                d.Display();
                if (d is IQuackable quackable) quackable.Quack();
                d.Swim();
                if (d is IFlyable flyable) flyable.Fly();

                Console.WriteLine();
            });
        }
    }
}
