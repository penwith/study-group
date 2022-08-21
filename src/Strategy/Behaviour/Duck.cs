using Behaviour.FlyBehaviour;
using Behaviour.QuackBehaviour;

namespace Behaviour
{
    public abstract class Duck
    {
        protected IFlyBehaviour _flyBehaviour;
        protected IQuackBehaviour _quackBehaviour;

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("All ducks can at least float...");
        }

        public void Quack()
        {
            _quackBehaviour.Quack();
        }

        public void Fly()
        {
            _flyBehaviour.Fly();
        }
    }
}
