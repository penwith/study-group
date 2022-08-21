namespace Inheritance
{
    public class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Squeak squeak...");
        }

        public override void Display()
        {
            Console.WriteLine("Rubber Duck");
        }
    }
}
