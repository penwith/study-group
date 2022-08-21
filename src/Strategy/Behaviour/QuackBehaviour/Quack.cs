namespace Behaviour.QuackBehaviour
{
    public class Quack : IQuackBehaviour
    {
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine("Quack quack...");
        }
    }
}
