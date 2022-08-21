namespace Override
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

        public override void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
