using Behaviour.FlyBehaviour;
using Behaviour.QuackBehaviour;

namespace Behaviour
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehaviour = new FlyWithWings();
            _quackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("Mallard Duck");
        }
    }
}
