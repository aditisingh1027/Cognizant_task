# Dependency Inversion Principle (DIP)

**Concept Overview**
The Dependency Inversion Principle encourages high‑level modules to depend on abstractions rather than concrete implementations. This decouples the system, making it easier to change or replace low‑level details.

**Real‑world Use Case**
A business service (high‑level) might need to perform calculations, but it shouldn't be tied to a specific calculator implementation. By depending on an `ICalculator` interface, any concrete calculator can be supplied (e.g., a simple calculator, a scientific one, or a mock for testing).

**Implementation Details**
- `ICalculator` – abstraction defining a single `Add` method.
- `SimpleCalculator` – concrete low‑level class implementing `ICalculator`.
- `MathClient` – high‑level class that receives an `ICalculator` via constructor injection and uses it.
- `DependencyInversionDemo.Run()` – static demo that creates a `SimpleCalculator`, injects it into `MathClient`, and calls `PerformAddition()`.

**How to Run**
```csharp
SOLIDPrinciples.DIP.DependencyInversionDemo.Run();
```
Invoke the static `Run()` method from any entry point (e.g., a unit test or another demo) to see the output.
