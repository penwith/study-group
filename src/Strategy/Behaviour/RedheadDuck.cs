using Behaviour.FlyBehaviour;
using Behaviour.QuackBehaviour;

namespace Behaviour
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            _flyBehaviour = new FlyWithWings();
            _quackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("RedheadDuck Duck");
        }
    }
}
