# Linked List

## Concept Overview
A singly linked list is a linear collection of nodes where each node points to the next one. It allows O(1) insertion at the tail and O(n) traversal.

## Real‑world Example
Processing streams of data where you need to append items frequently without random access, such as building a log of events.

## Implementation Details
- `Node<T>` – holds a value and a reference to the next node.
- `SinglyLinkedList<T>` – maintains `head` and `tail`, provides `Add(T value)` and `Traverse()` returning an `IEnumerable<T>`.
- `LinkedListDemo.Run()` – creates a list, adds a few integers, and prints them.

## How to Run
```csharp
DSA.LinkedList.LinkedListDemo.Run();
```
