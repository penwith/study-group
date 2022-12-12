﻿namespace Inheritance
{
    public class Sim
    {
        public void Run()
        {
            var ducks = new List<Duck>
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck()
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
    }
}
