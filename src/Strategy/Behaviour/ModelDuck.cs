using Behaviour.FlyBehaviour;
using Behaviour.QuackBehaviour;

namespace Behaviour
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehaviour = new NoFly();
            _quackBehaviour = new Mute();
        }

        public void SetFlyBehaviour(IFlyBehaviour flybehaviour)
        {
            _flyBehaviour = flybehaviour;
        }

        public override void Display()
        {
            Console.WriteLine("Model Duck");
        }
    }
}
