namespace Interface
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("Mallard Duck");
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
