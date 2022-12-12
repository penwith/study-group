namespace Singleton
{
    public class LazyInstantiation
    {
        private static LazyInstantiation _instance;

        private LazyInstantiation() { }

        public static LazyInstantiation Instance()
        {
            if (_instance == null)
                _instance = new LazyInstantiation();

            return _instance;
        }

        private string _greeting = "Some default greeting";

        public string Greeting
        {
            get { return _greeting; }
            set { _greeting = value; }
        }
    }
}
