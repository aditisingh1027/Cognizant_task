# Single Responsibility Principle (SRP)

This project demonstrates the **Single Responsibility Principle**.  The folder contains:

- **BadImplementation.cs** – a class that mixes multiple responsibilities (data access, validation, and presentation).
- **GoodImplementation.cs** – a clean separation into `OrderRepository`, `OrderValidator`, and `OrderPrinter`.
- **Program.cs** – a simple console driver that uses the good implementation.
- **SRP.csproj** – .NET 8 console project file.

Run the project with `dotnet run` from the `SRP` folder.
