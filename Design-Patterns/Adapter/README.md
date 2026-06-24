# Adapter Pattern

The **Adapter** pattern allows incompatible interfaces to work together by translating one interface to another that a client expects.

### Participants
- **ITarget** – the target interface used by the client.
- **Adaptee** – an existing class with an incompatible interface.
- **Adapter** – implements `ITarget` and forwards calls to an `Adaptee` instance.
- **AdapterPattern** – static demo class exposing `Run()`.

### How to run the demo
```csharp
DesignPatterns.Adapter.AdapterPattern.Run();
```
The demo creates an `Adapter` around an `Adaptee` and calls `Request()`, which internally invokes `SpecificRequest()` on the adaptee.

*No `Program` or `Main` method is required; the static `Run` method can be invoked from any entry point or unit test.*
