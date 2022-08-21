namespace Interface
{
    public class RubberDuck : Duck, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("Rubber Duck");
        }

        public void Quack()
        {
            Console.WriteLine("Squeak squeak...");
        }
    }
}
