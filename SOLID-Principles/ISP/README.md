# Interface Segregation Principle (ISP)

**Concept Overview**
The Interface Segregation Principle states that no client should be forced to depend on methods it does not use. Instead of a single "fat" interface, create smaller, role‑specific interfaces.

**Real‑world Use Case**
Consider a billing system where some components only need billing operations while others need reporting. Rather than a single `IService` interface exposing both `GenerateBill` and `GenerateReport`, we split them into `IBilling` and `IReporting`.

**Implementation Details**
- `IBilling` – defines `GenerateBill()`.
- `IReporting` – defines `GenerateReport()`.
- `BillingService` implements only `IBilling`.
- `InterfaceSegregationDemo.Run()` shows a consumer using the `IBilling` interface without any awareness of reporting.

**How to Run**
```csharp
SOLIDPrinciples.ISP.InterfaceSegregationDemo.Run();
```
Call the static `Run()` method from any entry point (e.g., a unit test or another demo) to see the output.
