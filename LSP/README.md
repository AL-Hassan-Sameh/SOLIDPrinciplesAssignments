<p align="center">
  <img width="460" height="300" src="https://miro.medium.com/v2/resize:fit:1400/1*iV_TeHoEDE0TwhQEFj2fxA.png">
</p>

# Liksov Substitution Principle (LSP) Assignment Solution

## Original PHP Assignment

This C# project serves as a solution to an assignment based on the Liskov Substitution Principle (LSP) in object-oriented programming. The assignment was adapted from the original PHP project available [here](https://github.com/mmbakker/solid-design-principles/tree/main/LiskovSubstitution). The PHP project provided the foundation for this C# implementation.

## Assignment Overview

The assignment aimed to demonstrate the application of the Liskov Substitution Principle (LSP), ensuring that derived classes can be substituted for their base classes without affecting program behavior. The focus was on implementing various types of light sources (CFL, Incandescent, LED) and a socket to manage their power state. Each light source type had to inherit from a common abstract class `LightSource`, which implements the `ILightSource` interface. Additionally, the assignment demonstrated the usage of the LSP by ensuring that each derived light source class can substitute the base `LightSource` class without altering the expected behavior.

## Changes from Original PHP Assignment

- **Conversion to C#**: The assignment was originally written in PHP and has been converted to C#.
- **Class Structure**: The original individual classes for each light source (CFL, Incandescent, LED) were maintained, but now they inherit from a common abstract class `LightSource` to adhere to the LSP.
- **Abstract Class and Interface**: An abstract class `LightSource` was introduced, implementing the `ILightSource` interface. This ensures that all light source classes adhere to a common contract, facilitating polymorphism and adhering to the LSP.
- **Socket Class**: The `Socket` class, responsible for managing power state, was retained. However, its methods were adapted to reflect C# conventions.
- **Usage of LSP**: Each derived light source class (CFL, Incandescent, LED) is substitutable for the base `LightSource` class without affecting the expected behavior of the program. This adherence to the LSP allows for flexibility and extensibility in the codebase.

---
This solution demonstrates proficiency in applying the Liskov Substitution Principle (LSP) in software design and development, promoting flexibility, extensibility, and maintainability in the codebase.
