using SomeOtherLibrary;

namespace Simple
{
    public class Widget
    {
        private readonly string _message = "This is the bit I want to test...";
        private readonly ISuperUsefulThing _usefulThing;

        public Widget(string message, ISuperUsefulThing usefulThing)
        {
            _usefulThing = usefulThing;
        }

        //public Widget(string message, IUsefulThingFactory usefulThingFactory)
        //{
        //    _message = message;
        //    _usefulThing = usefulThingFactory.CreateUsefulThing();
        //}

        public string Process() => $"{_message}... {_usefulThing.Status}";

        public string UsefulStatus => _usefulThing.Status;
    }

    public interface IUsefulThingFactory
    {
        ISuperUsefulThing CreateUsefulThing();
    }
}
