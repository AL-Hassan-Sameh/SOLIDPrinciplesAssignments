<p align="center">
  <img width="460" height="300" src="https://miro.medium.com/v2/resize:fit:1200/1*YzBpqn1XSHOz9UpKc6HcJg.png">
</p>

# Interface Segregation Principle (ISP) Project

## Original PHP Project

This C# project is an adaptation of the original PHP project available [here](https://github.com/mmbakker/solid-design-principles/tree/main/LiskovSubstitution). The original PHP project served as the basis for this C# implementation.

## Overview

This project demonstrates the application of the Interface Segregation Principle (ISP) in object-oriented programming. ISP ensures that derived classes can be substituted for their base classes without affecting the behavior of the program.

The project focuses on implementing various game entities with different behaviors, adhering to the principles of ISP. Each game entity, such as Player, Wood, and Rock, implements specific interfaces representing their actions and attributes, promoting code modularity and reusability.

## Project Structure

The project is organized into several namespaces and files to maintain a clean and understandable structure. Here's an overview:

- **`ISPDemo`**: This is the root namespace of the project.

  - **`GameEntity`**: This namespace contains classes and interfaces related to game entities.

    - **`IGameEntity.cs`**: This file defines the `IGameEntity` interface, which contains common properties shared by game entities. This interface serves as a contract for all game entity classes to implement.

    - **`Collectable`**: This namespace contains classes and interfaces related to collectable entities.

      - **`ICollectable.cs`**: This file defines the `ICollectable` interface, which defines the behavior of collectable objects. Any class representing a collectable entity must implement this interface.

      - **`Wood`**: This namespace contains classes related to the Wood collectable entity.

        - **`Wood.cs`**: This file implements the `Wood` class, representing the Wood collectable entity. The class implements both the `IGameEntity` and `ICollectable` interfaces.

      - **`Rock`**: This namespace contains classes related to the Rock collectable entity.

        - **`Rock.cs`**: This file implements the `Rock` class, representing the Rock collectable entity. Similar to Wood, the class implements both the `IGameEntity` and `ICollectable` interfaces.

    - **`Player`**: This namespace contains classes and interfaces related to player entities.

      - **`IAttackable.cs`**: This file defines the `IAttackable` interface, which defines the behavior of attackable entities. Any class representing an attackable entity must implement this interface.

      - **`IRunnable.cs`**: This file defines the `IRunnable` interface, which defines the behavior of runnable entities. Any class representing a runnable entity must implement this interface.

      - **`Player.cs`**: This file implements the `Player` class, representing the player entity. The class implements the `IGameEntity` interface and includes methods to perform actions such as attack, run, and collect.

- **`GameWorld.cs`**: This file contains the `GameWorld` class, which represents the game world. In the constructor of this class, instances of various game entities are created and their behaviors are demonstrated.
