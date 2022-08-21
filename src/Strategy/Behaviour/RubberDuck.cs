using Behaviour.FlyBehaviour;
using Behaviour.QuackBehaviour;

namespace Behaviour
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyBehaviour = new NoFly();
            _quackBehaviour = new Squeek();
        }

        public override void Display()
        {
            Console.WriteLine("RubberDuck Duck");
        }
    }
}
