namespace Systems
{
    public abstract class Player
    {
        public abstract string Name { get; }

        public void On()
        {
            Console.WriteLine($"{Name} on");
        }

        public void Off()
        {
            Console.WriteLine($"{Name} off");
        }

        public void Play(string title)
        {
            Console.WriteLine($"{Name} playing {title}");
        }

        public void Pause()
        {
            Console.WriteLine($"{Name} paused");
        }

        public void Stop()
        {
            Console.WriteLine($"{Name} stopped");
        }
    }
}
