# Liskov Substitution Principle

This project demonstrates the application of the Liskov Substitution Principle (LSP) in object-oriented programming. LSP ensures that derived classes can be substituted for their base classes without affecting the behavior of the program.

## Original PHP Project

This C# project is an adaptation of the original PHP project available [here](https://github.com/mmbakker/solid-design-principles/tree/main/LiskovSubstitution). The original PHP project served as the basis for this C# implementation.

## Overview

The project implements various types of light sources (CFL, Incandescent, LED) and a socket to manage their power state. Each light source type inherits from a common abstract class `LightSource`, which implements the `ILightSource` interface. Additionally, the project demonstrates the usage of the LSP by ensuring that each derived light source class can substitute the base `LightSource` class without altering the expected behavior.

## Changes from Original PHP Project

- **Conversion to C#**: The project was originally written in PHP and has been converted to C#.
- **Class Structure**: The original individual classes for each light source (CFL, Incandescent, LED) were maintained, but now they inherit from a common abstract class `LightSource` to adhere to the LSP.
- **Abstract Class and Interface**: An abstract class `LightSource` was introduced, implementing the `ILightSource` interface. This ensures that all light source classes adhere to a common contract, facilitating polymorphism and adhering to the LSP.
- **Socket Class**: The `Socket` class, responsible for managing power state, was retained. However, its methods were adapted to reflect C# conventions.
- **Usage of LSP**: Each derived light source class (CFL, Incandescent, LED) is substitutable for the base `LightSource` class without affecting the expected behavior of the program. This adherence to the LSP allows for flexibility and extensibility in the codebase.
