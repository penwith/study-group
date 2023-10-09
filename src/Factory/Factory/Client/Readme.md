# OO Principles

## Encapsulate what varies

The technique of reducing the impact of refrequently changing code by encapsulating it. The encapsulated code can then change idependently to the code that relies on it.

> Refers to the bundling of data with the mechanisms or methods that operate on the data. It may also refer to the limiting of direct access to some of that data, such as an object's components. Encapsulation allows developers to present a consistent and usable interface which is independent of how a system is implemented internally.

## Favour composition over inheritance

Suggests that, in many scenarios, composition can be a more flexible and maintainable approach. By leveraging composition, code can be structured to encoureage reuse, modularity, and polymorphic behaviour.

> Inheritance has the strength of establishing a hierarchical structure, enabling code reuse, and defining common behaviour among related classes. It *can* lead to tight coupling and limited flexibility.

> Composition offers several advantages. It *promotes* loose coupling and flexibility by allowing objects to be constructed from different components. It *encourages* the use of interfaces to define behaviors that can be implemented by multiple classes. Composition *enhances* modularity and *facilitates* easy modification or extension of objects by adding or replacing components.

## Program to an interface, not an implementation

When client code holds a reference to an interface, rather than an implementation of that interface, it is limited to operations defined by that contract. All types that implement that contract can then be used polymorphically by the client, making the design more flexible and, often, easier to maintain.

## Strive for loosely coupled designs between objects that interact

Coupling refers to the degree of direct knowledge that one component has of another. The goal of loose coupling is to reduce the risk that changes made to one component will create unexpected changes in other components. Limiting interconnections cna help isolate problems when things go wrong, simplify testing, and ease maintenance.

## Classes should be open for extension but closed for modification

In our designs we should allow bahaviour to be extended without the need to modify existing code.

# Concepts

## Good OO designs are resusable, extensible, and maintainable

## Most patterns and principles address issues of *change* in software

## Most patterns allow some part of a system to vary independently of all other parts

## We often try to take what varies in a system and encapsulate it
