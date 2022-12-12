using Common;
using Demos;
using Demos.Pizzas;
using FakeItEasy;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Testing
{
    public class Tests
    {
        ILogger _fakeLogger;
        IPizzaFactory _fakePizzaFactory;

        Pizza _mockPizza;

        [SetUp]
        public void Setup()
        {
            _fakeLogger = A.Fake<ILogger>();    
            _fakePizzaFactory = A.Fake<IPizzaFactory>();

            _mockPizza = new TestPizza(_fakeLogger);

            A.CallTo(() => _fakePizzaFactory.CreatePizza(A<string>.Ignored)).Returns(_mockPizza);
        }

        [Test]
        public async Task Test1Async()
        {
            var sut = new Demo3(_fakeLogger, _fakePizzaFactory);

            await sut.Process();

            A.CallTo(() => _fakeLogger.LogError("Pizza was inedible - Blerg... Turnips!"))
                .MustHaveHappenedOnceExactly();
        }
    }
}