# Task 1 - Let's watch a film

1. Turn on the popcorn popper
1. Start the popcorn popper popping
1. Close the blinds
1. Dim the lights
1. Put the screen down
1. Turn the streaming player on
1. Turn the projector on
1. Set the projector to cinematic wide-screen mode
1. Turn the amplifier on
1. Set the amplifier input to streaming player
1. Set the amplifier to surround sound
1. Set the amplifier volume to medium (5)
1. Play the movie 'Dune'

## Questions

- When the film is over, how do you turn everything off?
- Is it the same process to listen to the radio?
- What happens when you upgrade your kit? Is the process likely to stay the same?
- How can we reduce the complexity of this system, for the clients that may use it?

# Introducing the Facade Pattern

With the Facade Pattern you can take a complex subsystem and make it easier to use by implementing a Facade class that provides one, 
more reasonable, interface.

If you *need* the power of the complex subsystem, it's still there for you to use, but if all you need is a straightforward interface, 
the Facade is there for you.

# Task 2 - Create a Facade class

Create a new class - let's call it Alexa - which exposes simple methods to watch a film and end a film.
This class should treat the home theatre components as a subsystem, and call on that subsystem to implement its methods.

Modify the client to use your facade instead of the low level objects.

## Questions

- Is the subsystem still accessible?
- How can you adjust the volume while your film is playing?
- Does the facade add any functionality or does it just pass through each request to the subsystem?
  - A facade is free to add any logic it needs to 
  - While our facade doe not implement any new behaviour, it does know that we must turn on a projector befor using it and 
what order the components of the subsystem can be used in
- Are we limited to a single facade for a subsystem?
- What is the benefit of the facade, other than providing a simpler interface?
  - The pattern allows you to decouple your clients implementation from any one subsystem
  - If you upgrade your subsystem, the new components may have different interfaces
  - With a facade you will not have to change your client code (which may implement many other features that you do not was to risk breaking)
- What is the difference between the Adapter Pattern and the Facade Pattern?
  - The difference is in their *intent*
  - The intent of the Adapter Pattern is to alter an interface so that it matches one a client is expecting
  - The intent of the Facade Pattern is to provide a simplified interface to a subsystem

### Takeaways

A facade not only simplifies an interface, it decouples a client from a subsystem of components

Facades and adapters may 'wrap' multiple classes, but a facade's intent is to simplify, while an adapter's is to convert the interface to something 
different

# Pattern Definition

The Facade Pattern provides a unified interface to a set of interfaces in a subsystem.
Facade defines a higher-level interface that make the subsystem easier to use.

# Design Principle

Principle of Least Knowledge: talk only to your immediate friends

## What does this mean?

The Principle of Least Knowledge guides us to reduce the interactions between objects to just a few close 'fiends', but what does this mean?
It means when you are designing a system, for any object, be careful of the number of classes it interacts with and also how it comes to interact with 
those classes.

This principle prevents us from creating design that have a large number of classes coupled together, so that changes to one partof the system 
cascade to other parts. When you build a lot of dependencies between many classes, you are building a fragile system thay may be costly to maintain 
and complex for others to understand.

## Guidelines

Take any object, and from any method in that object, invoke only methods that belong to:

- The object itself
- Objects passed in a parameter to the method
- Any object the method creates or instantiates
- Any components of the object

Note: These guidelines tell us not to call methods on objects that were returned from calling other methods.

Think of a 'component' as any object that is referenced by an instance variable (HAS-A relationship)

## Question

Where is the harm in calling the method of an object we get back from another call?

- We would be making a request of another object's subpart, and increasing the number of objects we directly know.
Better to ask the object to make the request for us.

### Without the Principle
```
public float GetTemp()
{
    Thermometer thermometer = station.GetThermometer();
    return thermometer.GetTemperature();
}
```

### With the Principle
```
public float GetTemp()
{
    return station.GetTemperature();
}
```

## Also known as...

The Law of Demeter

They are the same thing, although 'law' implies that it must be followed, when in fact all design involves tradeoffs in practice.

## Any disadvantages to this Principle?

While this principle reduces dependencies between objects and so maintenance, it does results in more 'wrapper' classes being written
to handle method calls to other components. This can result in increased complexity, development time and runtime performance.