using Singleton;

Console.WriteLine("Hello World");

//var first = new LazyInstantiation();

var first = LazyInstantiation.Instance();

Console.WriteLine(first.Greeting);