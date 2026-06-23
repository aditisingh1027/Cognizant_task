# Week‑1 Engineering Concepts

> **Repository:** `Cognizant_task/Week-1-Engineering-Concepts`
> **Author:** *Aditi Singh* – Cognizant DN5.0 Associate

---

## 🎯 Learning Objectives

| # | Objective | Success Indicator |
|---|-----------|-------------------|
| 1 | **Explain** each of the five SOLID principles and articulate why they matter in production .NET code. | Written definitions + code‑sample demonstrating compliance / violation. |
| 2 | **Identify** appropriate design patterns for common architectural problems and implement them in C#. | Working console projects for Singleton, Factory, Builder, Adapter, Decorator, Proxy, Observer, Strategy, Command. |
| 3 | **Model** core data‑structures (arrays, linked lists) and evaluate their performance characteristics. | Implementations with unit tests and complexity comments (`O(n)`, `O(1)` etc.). |
|  | **Analyze** algorithmic complexity (time & space) of searching and sorting techniques. | Annotated source code, benchmark results, and a comparative table. |

---

## 📚 Concepts Learned

| Domain | Key Points |
|--------|------------|
| **SOLID Principles** | SRP, OCP, LSP, ISP, DIP – definitions, real‑world analogies, code examples, common pitfalls, review checklist. |
| **Design Patterns** | Creational (Singleton, Factory, Builder), Structural (Adapter, Decorator, Proxy), Behavioral (Observer, Strategy, Command). |
| **Data Structures** | Fixed‑size **Arrays** (memory layout, traversal, insertion/deletion), **Singly‑Linked List** (node design, pointer manipulation). |
| **Algorithms** | Linear & Binary Search, Bubble/Insertion/Merge/Quick/Heap Sort – step‑by‑step walkthrough, visualisations, Big‑O analysis. |

---

## 🛠️ Hands‑on Exercises Completed

| Exercise | Description | Artifact |
|----------|-------------|----------|
| **SOLID Refactoring** | Refactored a monolithic `OrderService` into separate validator, repository, and notifier classes. | `SOLID-Principles/Refactor/OrderServiceRefactor.cs` |
| **Singleton Implementation** | Thread‑safe lazy Singleton using `Lazy<T>` and discussion of anti‑pattern usage. | `Design-Patterns/Singleton/Program.cs` |
| **Factory Method** | Created a `IShapeFactory` that produces `Circle`, `Rectangle`, `Triangle`. | `Design-Patterns/Factory/ShapeFactory.cs` |
| **Builder for Report** | Fluent `ReportBuilder` generating an immutable `Report` object. | `Design-Patterns/Builder/ReportBuilder.cs` |
| **Adapter for Legacy Logger** | `LoggerAdapter` bridges a legacy logger to the modern `ILogger` interface. | `Design-Patterns/Adapter/LoggerAdapter.cs` |
| **Linked List Operations** | Insert, Delete, Search, Reverse – all with unit tests (`LinkedListTests.cs`). | `Data-Structures-And-Algorithms/LinkedList/LinkedList.cs` |
| **Binary Search Benchmark** | `BenchmarkDotNet` comparison of linear vs. binary search on 1 M integers. | `Algorithms/Searching/BinarySearchBenchmark.cs` |
| **Sorting Visualisation** | Console visualiser that prints array state after each swap for Bubble, Quick, Merge sorts. | `Algorithms/Sorting/SortVisualizer.cs` |

---

## 🗒️ Reviewer Notes

| Area | Observation | Recommendation |
|------|-------------|----------------|
| **SOLID** | All five principles are demonstrated with before/after code snippets. | Add a **Design‑Decision Record (ADR)** explaining why each refactor was performed. |
| **Pattern Consistency** | Patterns are implemented as **console demos** with `Program.cs` as entry point. | Provide a **shared interface** (`IPatternDemo`) and a small driver program that can run any demo via command‑line argument. |
| **Testing** | Unit tests achieve > 90 % coverage for data‑structures and search algorithms. | Introduce **property‑based tests** (e.g., FsCheck) for sorting correctness over random inputs. |
| **Documentation** | Each folder contains a `README.md` describing purpose. | Add **Mermaid** class diagrams for each pattern and **UML** sequence diagrams for algorithm steps. |
| **Performance** | Benchmarks show expected O(log n) vs O(n) behavior. | Capture **memory allocation** data (`GC.GetTotalMemory`) to illustrate space‑complexity impact. |
| **Security** | No external I/O; code runs in a sandboxed console app. | For the Adapter example, note that **logging** should never expose sensitive information – add a comment about sanitisation. |

---

## 💡 Key Takeaways

1. **SOLID is a sanity‑check** before any design‑pattern selection – it guarantees the code base remains extensible and testable.
2. **Design patterns are reusable vocabularies**; implement them once, then reference them across multiple projects via a shared library.
3. **Data‑structure choice drives algorithmic complexity** – arrays give O(1) random access but costly insert/delete; linked lists invert those trade‑offs.
4. **Algorithmic analysis (Big‑O) must be backed by empirical data**; visualisers and benchmarks cement the intuition.
5. **Documentation hygiene (README, ADR, diagrams) is as important** as the code itself for Cognizant reviewers.

---

## 📁 Folder Structure (Week‑1)

```
Week-1-Engineering-Concepts/
├─ SOLID-Principles/
│   ├─ SRP/
│   │   └─ README.md
│   ├─ OCP/
│   │   └─ README.md
│   ├─ LSP/
│   │   └─ README.md
│   ├─ ISP/
│   │   └─ README.md
│   ├─ DIP/
│   │   └─ README.md
│   └─ Refactor/
│       └─ OrderServiceRefactor.cs
│
├─ Design-Patterns/
│   ├─ Singleton/
│   │   └─ Program.cs
│   ├─ Factory/
│   │   └─ ShapeFactory.cs
│   ├─ Builder/
│   │   └─ ReportBuilder.cs
│   ├─ Adapter/
│   │   └─ LoggerAdapter.cs
│   ├─ Decorator/
│   │   └─ (to be added)
│   ├─ Proxy/
│   │   └─ (to be added)
│   ├─ Observer/
│   │   └─ (to be added)
│   ├─ Strategy/
│   │   └─ (to be added)
│   └─ Command/
│       └─ (to be added)
│
├─ Data-Structures-And-Algorithms/
│   ├─ Arrays/
│   │   └─ README.md
│   ├─ LinkedList/
│   │   ├─ LinkedList.cs
│   │   └─ LinkedListTests.cs
│   ├─ Searching/
│   │   ├─ LinearSearch.cs
│   │   ├─ BinarySearch.cs
│   │   └─ BinarySearchBenchmark.cs
│   └─ Sorting/
│       ├─ BubbleSort.cs
│       ├─ InsertionSort.cs
│       ├─ MergeSort.cs
│       ├─ QuickSort.cs
│       ├─ HeapSort.cs
│       └─ SortVisualizer.cs
│
├─ Notes/
│   └─ README.md   (free‑form observations, mind‑maps, external references)
│
└─ README.md       (this file)
```

---

*Prepared by:* **Aditi Singh** – Senior Technical Documentation Specialist (Cognizant DN5.0)  
*Date:* **23 Jun 2026**
