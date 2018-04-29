# Structural Design Patterns
Repository containing examples and studies about some structural design patterns. The scope of this respository involves Adapter, Composite and Decorator.

The content of this repository is a result of my study of the book *Design Patterns. Bookman Ed. GAMMA, E.; HELM, R. JOHNSON, R.; VLISSIDES, J.*

## Structural patterns
Structural patterns has the concern with the form of classes and objects are composed to be bigger structures. Structural patterns uses inheritance to compose interfaces or implementations.

## Adapter
- Objective
The objective of this pattern is convert a class interface into another interface that is expected by new client. Adapter lets classes work together that couldn't otherwise because of incompatible structures.
- Applicability
    - When you want to use an existent class, but it's interface doesn't correspond to client's neededs.
    - When you want to call an reusable class that work with another non-related code or doesn't have compatible interfaces
- Code
This code is composed by three classes: Adapter, Adaptee and Target
    - **Target**: Is the class that is incompatible to client's code and we want to use.
    - **Adapter**: Is the class which is responsible for creating a tier between the target and client's code. The client code will call this class and expect to use same methods of *Target* class.
    - **Adaptee**: Is the class that will provide the specific request to client through *Adapter* class

## Composite
- Objective
The objective of this pattern is to compose objects into tree-structures to represent an hierarchy part-total. Also this pattern allow clients deal in a uniform way individual objects and compositions.
- Applicability
    - When you want to represent hierarchy part-total of objects
    - When you want to clients be capable of ignore difference between object compositions and object individuals. All objects will be treated the same way.
- Code
This code is composed by two types of class: leaf and composite. All classes shares the same parent abstract class.
    - **Leaf**: Classes which has simple behaviors, in this example they are simple geometrical forms, like horizontal line or vertical line.
    - **Composite**: Classes that controls the use of one or more leaf class. They have same parent abstract class that leaf classes, the difference between them is their behaviors. In this example the *Picture* class has a dynamic list of leafs and the *Draw()* method call all draw methods of it's childs.

## Decorator
- Objective
Aggregate dinamically additional responsabilities to an object. Decorators provides an flexible alternative to use of subclasses for extension of features.
- Applicability
    - To add responsabilities in objects dinamically
    - To responsabilities that could be removed
    - When extension through subclass isn't possible
- Code
This example has the example of use of dynamic use of wrapper class that will be much more complex if was using simple inheritance. This example shows a pizza that can have toppings choosed by client dynamically and affecting it's
This code is composed by three classes: Adapter, Adaptee and Target price.
