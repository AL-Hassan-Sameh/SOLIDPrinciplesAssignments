<p align="center">
  <img width="460" height="300" src="https://miro.medium.com/v2/resize:fit:1200/1*YzBpqn1XSHOz9UpKc6HcJg.png">
</p>

# Interface Segregation Principle (ISP) Assignment Solution

## Original PHP Assignment

This C# project serves as a solution to an assignment based on the Interface Segregation Principle (ISP) in object-oriented programming. The assignment was adapted from the original PHP project available [here](https://github.com/mmbakker/solid-design-principles/tree/main/InterfaceSegregation). The PHP project provided the foundation for this C# implementation.

## Assignment Overview

The assignment aimed to demonstrate the application of the Interface Segregation Principle (ISP), ensuring that derived classes can be substituted for their base classes without affecting program behavior. The focus was on implementing various game entities with distinct behaviors, following the principles of ISP. Each game entity, such as Player, Wood, and Rock, had to implement specific interfaces representing their actions and attributes, promoting code modularity and reusability.

## Project Structure

The project is structured into several namespaces and files to maintain a clean and understandable layout. Here's a breakdown:

- **`ISPDemo`**: Root namespace of the assignment solution.

  - **`GameEntity`**: Namespace containing classes and interfaces related to game entities.

    - **`IGameEntity.cs`**: Interface defining common properties shared by game entities. Serves as a contract for all game entity classes to implement.

    - **`Collectable`**: Namespace for collectable entities and interfaces.

      - **`ICollectable.cs`**: Interface defining behavior for collectable objects.

      - **`Wood`**: Namespace for the Wood collectable entity.

        - **`Wood.cs`**: Class implementing the Wood collectable entity. Implements both `IGameEntity` and `ICollectable` interfaces.

      - **`Rock`**: Namespace for the Rock collectable entity.

        - **`Rock.cs`**: Class implementing the Rock collectable entity. Similar to Wood, it implements both `IGameEntity` and `ICollectable` interfaces.

    - **`Player`**: Namespace for player entities and related interfaces.

      - **`IAttackable.cs`**: Interface defining behavior for attackable entities.

      - **`IRunnable.cs`**: Interface defining behavior for runnable entities.

      - **`Player.cs`**: Class implementing the player entity. Implements the `IGameEntity` interface and includes methods for actions such as attack, run, and collect.

- **`GameWorld.cs`**: Class representing the game world. In its constructor, instances of various game entities are created and their behaviors are demonstrated.

---
This solution demonstrates proficiency in applying the ISP in software design and development, promoting clean, modular, and reusable code.
