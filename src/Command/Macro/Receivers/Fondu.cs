namespace Macro.Receivers
{
    public class Fondu
    {
        private readonly string _location;

        public Fondu(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine($"{_location} Fondu is on");
        }

        public void Off()
        {
            Console.WriteLine($"{_location} Fondu is off");
        }
    }
}
