namespace Override
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Decoy Duck");
        }

        public override void Quack()
        {
            Console.WriteLine("...");
        }

        public override void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
