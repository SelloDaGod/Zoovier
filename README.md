# Zoo Animals Console Application ReadMe
## Overview
Welcome to the Zoo Animals Console Application! This application demonstrates the use of Object-Oriented Programming (OOP) principles and UML diagrams to model a zoo with different types of animals. The application showcases inheritance, abstraction, encapsulation, and polymorphism through a hierarchy of classes.

UML Diagram
Below is the UML diagram representing the hierarchy of animal classes in the zoo:

UML Diagram

## Explanation:

The Animal class is an abstract class that serves as the base class for all animals in the zoo. It contains common properties like Name and Age and abstract methods like Eat() and Sound().

The Mammal class is an abstract class that inherits from Animal. It introduces the GiveBirth() abstract method, specific to mammals.

The Bird class is an abstract class that also inherits from Animal. It introduces the Fly() abstract method, specific to birds.

The Reptile class is an abstract class that inherits from Animal. It introduces the ShedSkin() abstract method, specific to reptiles.

The Elephant, Lion, Penguin, Eagle, Snake, and Turtle classes are concrete classes that inherit from their respective base classes. These concrete classes implement the abstract methods defined in their parent classes and may also override virtual methods to provide specific behavior.

## Program Structure
The Zoo Animals Console Application follows the specified requirements and includes the following:

## Abstract Classes:

Animal: Contains common properties and abstract methods for all animals.
Mammal: Inherits from Animal and introduces the GiveBirth() abstract method.
Bird: Inherits from Animal and introduces the Fly() abstract method.
Reptile: Inherits from Animal and introduces the ShedSkin() abstract method.
Concrete Animals:

Elephant: Inherits from Mammal.
Lion: Inherits from Mammal.
Penguin: Inherits from Bird.
Eagle: Inherits from Bird.
Snake: Inherits from Reptile.
Turtle: Inherits from Reptile.
Abstract and Virtual Methods and Properties:

Animal: Contains abstract methods Eat() and Sound().
Mammal: Contains abstract method GiveBirth().
Bird: Contains abstract method Fly().
Reptile: Contains abstract method ShedSkin().
Polymorphism:

Polymorphism is demonstrated through method overriding in the concrete animal classes. For example, the Eat() method in each concrete class provides specific implementation as required.
Usage
To run the Zoo Animals Console Application, simply build and execute the program in Visual Studio or any compatible C# development environment. The program will instantiate each of the concrete animals, showcase their behaviors, and prove that they inherit traits from their parent classes.

Please follow the instructions displayed on the console during the program execution.
