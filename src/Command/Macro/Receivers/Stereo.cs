namespace Macro.Receivers
{
    public class Stereo
    {
        private readonly string _location;

        public Stereo(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine($"{_location} music is on");
        }

        public void Off()
        {
            Console.WriteLine($"{_location} music is off");
        }
    }
}
