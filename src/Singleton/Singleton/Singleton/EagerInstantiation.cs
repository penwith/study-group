namespace Singleton
{
    public class EagerInstantiation
    {
        // .NET guarantees thread safety for static initialisation
        private static EagerInstantiation _instance = new EagerInstantiation();

        private EagerInstantiation() { }

        public static EagerInstantiation Instance()
        {
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
