namespace Behaviour.FlyBehaviour
{
    public class NoFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
