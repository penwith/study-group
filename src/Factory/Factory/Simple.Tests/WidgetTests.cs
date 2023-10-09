using FakeItEasy;
using SomeOtherLibrary;
using FluentAssertions;

namespace Simple.Tests
{
    public class Tests
    {
        private SuperUsefulThing _superUsefulThing;
        private const string Message = "This is a great test";

        private ISuperUsefulThing _fakeSuperUsefulThing;

        private IUsefulThingFactory _fakUsefulThingFactory;

        [SetUp]
        public void Setup()
        {
            //_superUsefulThing = new SuperUsefulThing();
            _fakUsefulThingFactory = A.Fake<IUsefulThingFactory>();

            _fakeSuperUsefulThing = A.Fake<ISuperUsefulThing>();
        }

        [Test]
        public void Widget_Process_ReturnsExpectedString()
        {
            var sut = new Widget(Message, _fakUsefulThingFactory);

            sut.Process().Should().Be($"I can tell you that... {Message}");
        }
    }
}