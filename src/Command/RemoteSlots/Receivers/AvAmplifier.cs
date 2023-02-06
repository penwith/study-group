namespace RemoteSlots.Receivers
{
    public class AvAmplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier is on");
        }
        public void Off()
        {
            Console.WriteLine("Amplifier is off");
        }
        public void SetSpotify()
        {
            Console.WriteLine("Amplifier set to play Spotify");
        }
        public void SetAppleTv()
        {
            Console.WriteLine("Amplifier set to play Apple TV");
        }
        public void SetInternetRadio()
        {
            Console.WriteLine("Amplifier set to play Internet Radio");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine($"Amplifier set to volume {volume}");
        }
    }
}
