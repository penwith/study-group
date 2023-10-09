namespace SomeOtherLibrary
{
    public class SuperUsefulThing
    {
        public SuperUsefulThing()
        {
            
        }

        public string Status => "I am very useful";
    }

    public class SomeOtherThing
    {
        private string _message;

        internal SomeOtherThing(string message)
        {
            _message = message;
        }

        public string Message => _message;
    }
}
