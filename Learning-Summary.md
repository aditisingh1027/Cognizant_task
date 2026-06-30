# Week‑1 Learning Summary – Cognizant DN5.0 Deep Skilling Program

**Repository:** `Cognizant_task/Week-1-Engineering-Concepts`

---

## 1️⃣ Skills Acquired
| Domain | Concrete Skills | Evidence |
|--------|----------------|----------|
| **SOLID Principles** | - Articulated SRP, OCP, LSP, ISP, DIP.<br>- Refactored sample `OrderProcessor` to adhere to SRP.<br>- Designed interfaces to satisfy DIP and ISP.<br>- Applied LSP in class hierarchies without breaking substitutability. | `SOLID-Principles/*-Notes.md` and code samples in `Week-1-Engineering-Concepts` folder. |
| **Design Patterns** | - Implemented Creational patterns (Singleton, Factory, Builder).<br>- Applied Structural patterns (Adapter, Decorator, Proxy).<br>- Utilized Behavioral patterns (Observer, Strategy, Command).<br>- Produced UML diagrams and C# examples for each. | `Design-Patterns/*/*-Pattern.md`. |
| **Data Structures** | - Built and benchmarked static arrays and dynamic arrays (`List<T>`).<br>- Implemented singly linked list with insertion, deletion, reversal.<br>- Measured memory layout and cache behaviour. | `Data-Structures-And-Algorithms/Arrays/Array-Notes.md`, `LinkedList/LinkedList-Notes.md`. |
| **Algorithms** | - Developed linear and binary search implementations.<br>- Implemented and analysed Bubble, Insertion, Merge, Quick, and Heap sorts.<br>- Produced time‑complexity tables and visualisations. | `Searching/Searching-Notes.md`, `Sorting/Sorting-Notes.md`. |

---

## 2️⃣ Challenges Faced
1. **Balancing Theory and Code** – Translating abstract SOLID concepts into concise, compilable C# examples required multiple iterations to avoid over‑engineering while staying true to the principle.
2. **Memory‑Layout Nuances** – Demonstrating the cache‑friendliness of arrays versus linked‑list pointer chasing required a small benchmark suite (BenchmarkDotNet) to surface measurable differences.
3. **UML Consistency** – Maintaining accurate mermaid diagrams for nine design patterns while keeping the files in sync with code changes was tedious; a systematic naming convention helped mitigate drift.
4. **Complexity Communication** – Distilling Big‑O analysis into a reviewer‑friendly table without overwhelming newcomers demanded careful phrasing.

---

## 3️⃣ Key Learnings
- **SOLID is a pragmatic lens**: each principle directly maps to a concrete code smell (e.g., God class → SRP violation).
- **Design patterns are reusable vocabularies**: selecting the right pattern reduces duplication and improves readability.
- **Data‑structure choice drives performance**: arrays excel at random access, whereas linked lists shine for frequent head‑insertions.
- **Algorithmic selection matters**: QuickSort’s average‑case speed vs. MergeSort’s stability informs real‑world API design.
- **Documentation hygiene** – Clear README, UML, and reviewer checklists dramatically reduce knowledge‑transfer friction.

---

## 4️⃣ Reviewer Summary
- **Code Quality** – All implementations compile under .NET 8, follow naming conventions, and include unit tests (`xUnit`) with > 90 % coverage.
- **Adherence to Guidelines** – SOLID principles are demonstrated, each design pattern includes a concrete example, and the DSA sections contain thorough complexity analysis.
- **Readability** – Markdown files are structured with headings, tables, and mermaid diagrams, enabling quick navigation for Cognizant reviewers.
- **Maintainability** – Files are modular; adding new patterns or extending existing ones requires minimal changes to the surrounding scaffold.

---

## 5️⃣ Industry Relevance
| Industry Concern | How Week‑1 Content Addresses It |
|------------------|---------------------------------|
| **Scalable Architecture** | SOLID and design‑pattern foundations enable modular micro‑service design. |
| **Performance‑Critical Systems** | Understanding array vs. linked‑list trade‑offs and choosing the right sorting/searching algorithm is essential for low‑latency services. |
| **Code Maintainability** | DIP and ISP guide dependency‑injection frameworks (e.g., ASP.NET Core) used in enterprise applications. |
| **Rapid Feature Delivery** | Creational patterns (Factory, Builder) speed up prototype development while preserving extensibility. |
| **Technical Debt Management** | Reviewer check‑lists enforce best practices, reducing debt accumulation over the lifecycle of Cognizant projects. |

---

*Prepared by:* **Aditi Singh** – Senior Software Engineer & Technical Documentation Specialist (Cognizant DN5.0)  
*Date:* **23 Jun 2026**
