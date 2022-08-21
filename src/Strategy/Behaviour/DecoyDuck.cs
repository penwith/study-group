using Behaviour.FlyBehaviour;
using Behaviour.QuackBehaviour;

namespace Behaviour
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            _flyBehaviour = new NoFly();
            _quackBehaviour = new Mute();
        }

        public override void Display()
        {
            Console.WriteLine("Decoy Duck");
        }
    }
}
