namespace Inheritance
{
    public abstract class Duck
    {
        public virtual void Quack()
        {
            Console.WriteLine("Quack quack...");
        }

        public void Swim()
        {
            Console.WriteLine("All ducks can at least float...");
        }

        //public void Fly()
        //{
        //    Console.WriteLine("I'm flying...");
        //}

        public abstract void Display();
    }
}
