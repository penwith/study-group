namespace Singleton
{
    public class DoubleCheckedLock
    {
        static DoubleCheckedLock _instance;

        private static object locker = new object();

        private DoubleCheckedLock() { }

        public static DoubleCheckedLock Instance()
        {
            if (_instance == null)
            {
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new DoubleCheckedLock();
                    }
                }
            }

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
