using Behaviour.FlyBehaviour;

namespace Behaviour
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
                d.Quack();
                d.Swim();
                d.Fly();

                Console.WriteLine();
            });
        }

        public void RunX()
        {
            var duck = new ModelDuck();

            duck.Display();
            duck.Quack();
            duck.Swim();
            duck.Fly();

            duck.SetFlyBehaviour(new RocketPowered());
            duck.Fly();
        }
    }
}
