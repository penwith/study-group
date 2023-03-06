namespace UndoState.Receivers
{
    public enum Speed
    {
        Off,
        Low,
        Medium,
        High
    }

    public class CeilingFan
    {
        private Speed _speed;
        private readonly string _location;

        public CeilingFan(string location)
        {
            _speed = Speed.Off;
            _location = location;
        }

        public void High()
        {
            _speed = Speed.High;
            Display(nameof(High));
        }

        public void Medium()
        {
            _speed = Speed.Medium;
            Display(nameof(Medium));
        }

        public void Low()
        {
            _speed = Speed.Low;
            Display(nameof(Low));
        }

        public void Off()
        {
            _speed = Speed.Off;
            Display(nameof(Off));
        }

        public Speed GetSpeed()
        {
            return _speed;
        }

        private void Display(string setting)
        {
            Console.WriteLine($"{_location} ceiling fan set to {setting}");
        }
    }
}
