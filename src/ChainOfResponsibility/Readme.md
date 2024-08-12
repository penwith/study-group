## Categorisation of Patterns

Design Patterns are generally categorised by purpose

### Creational Patterns

- Concern the process of object creation

### Structural Patterns

- Deal with the composition of classes or objects

### Behavioural Patterns

- Characterise the way in which classes or objects interact and distribute responsibility

They can also be categorised by scope

### Class Patterns

- Deal with relationships between classes and their subclasses. These relationships are mostly established through inheritance, so they are static, i.e. fixed at compile time.

### Object Patterns

- Deal with object relationships, which can be changed at run time and so are more dynamic.

![alt text](ByPurposeByScope.png)

- Creational class patterns defer some part of object creation to subslasses, while Creational object patterns defer it to another object.
- The Structural class patterns use inheritance to compose classes, while the Structural object patterns describe ways to assemble objects.
- The Bahavioural class patterns use inheritance to describe algorithms and flow of control, whereas the Bahavioural object patterns describe how a group of objects cooperate to performa a task that no single object can carry out alone.

## Behavioural Object Patterns in General

Behavioural object patterns use object composition rather that inheritance.

Some describe how a group of peer object cooperate to perform a task that no sngle object can carry out by itself. 

An important issue here is how peer objects know about each other. 

Peers could maintain explicit references to each other, but that would increase their coupling. 

In the extreme, every object would know about every other. 

*The State pattern avoids this by referencing interfaces rather than concrete types.*

Chain of Responsibility provides even looser coupling. 

It lets you send requests to an object implicitly through a chain of candidate objects. 

Any candidtate in the chain may fulfill the request depending on run-time conditions. 

The number of candidates is open-ended and you can select which candidates participate in the chain at run-time.

## Chain of Responsibility

# Intent

Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.

# Applicability

Use Chain of Responsibility when:

- More than one object may handle a request, and the handler isn't known in advance
- You want to issue a request to one of several objects without specifying the receiver explicitly
- The set of objects that can handle a request should be specified dynamically

# Participants

Handler 

- Defines an interface for handling requests
- Implements the successor link (optional)

Concrete Handler

- Handles requests it is responsible for
- Can access its successor

Client

- Initiates the request to the first Concrete Handler on the chain

# How is it different to Decorator

Wikipedia

- The chain-of-responsibility pattern is structurally nearly identical to the decorator pattern, the difference being that for the decorator, all classes handle the request, while for the chain of responsibility, exactly one of the classes in the chain handles the request

Stack Overlow

- I generally think of the Decorator as "adding" to some thing, where as Chain of Responsiblity is more like handling something thing.
- In comparing the two patterns the biggest difference is the Chain of Responsibility can kill the chain at any point.
- Think of decorators as a layered unit in which each layer always does pre/post processing. Chain of Responsibility is more like a linked list, and generally 1 thing handles processing.
- The Chain of Responsibility pattern allows for multiple things to handle an event but it also gives them the opportunity to terminate the chain at any point.
