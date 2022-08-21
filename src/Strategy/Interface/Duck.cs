namespace Interface
{
    public abstract class Duck
    {
        public void Swim()
        {
            Console.WriteLine("All ducks can at least float...");
        }

        public abstract void Display();
    }
}
