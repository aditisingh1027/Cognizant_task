# Observer Pattern

## Concept Overview
The Observer pattern defines a **one‑to‑many** relationship between a subject and its observers. When the subject's state changes, all registered observers are automatically notified.

## Real‑world Example
A news service (subject) pushes breaking news to subscribed mobile apps (observers).

## Implementation Details
- `ISubject` – registers, deregisters and notifies observers.
- `IObserver` – receives updates via `Update()`.
- `ConcreteSubject` – holds state and calls `NotifyObservers()`.
- `ConcreteObserver` – reacts to updates (writes to the console).
- `ObserverPattern.Run()` – demonstrates subscription, state change, and notification.

## How to Run
```csharp
DesignPatterns.Observer.ObserverPattern.Run();
```
