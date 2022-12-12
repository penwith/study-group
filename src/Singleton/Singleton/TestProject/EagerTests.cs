using FluentAssertions;
using NUnit.Framework;
using Singleton;

namespace TestProject
{
    public class EagerTests
    {
        [Test]
        public void Should_Reference_SameObject()
        {
            var ref1 = EagerInstantiation.Instance();
            var ref2 = EagerInstantiation.Instance();

            ref2.Should().BeSameAs(ref1);
        }

        [Test]
        public void Should__Still_Reference_SameObject()
        {
            var newGreeting = "I was set by ref2";

            var ref1 = EagerInstantiation.Instance();

            ref1.Greeting.Should().Be("Some default greeting");

            var ref2 = EagerInstantiation.Instance();

            ref2.Greeting = newGreeting;

            ref1.Greeting.Should().Be(newGreeting);
        }
    }
}