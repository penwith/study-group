namespace Systems
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier on");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier set to stereo output");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier set to surround sound");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Amplifier volume set to {volume}");
        }

        public void SetPlayer(Player player)
        {
            Console.WriteLine($"Amplifier player set to {player.Name}");
        }
    }
}
