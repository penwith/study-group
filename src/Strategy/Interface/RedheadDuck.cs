namespace Interface
{
    public class RedheadDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("Redhead Duck");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying...");
        }

        public void Quack()
        {
            Console.WriteLine("Quack quack...");
        }
    }
}
