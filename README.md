# C# Programming Practice Repository
## 📚 Overview :
A comprehensive collection of C# programming exercises, algorithms, data structures, and practical implementations designed to enhance C# development skills. This repository serves as both a learning resource and a reference guide for C# best practices, patterns, and modern language features.

## 🎯 Purpose :
- Practice and master C# programming concepts

- Implement common algorithms and data structures in C#
 
- Explore .NET features and best practices

- Prepare for technical interviews 

- Build reusable code snippets and utilities

## 📁 Repository Structure : 
```
CSharp-Practice/
├── Algorithms/          # Algorithm implementations
│   ├── Sorting/
│   ├── Searching/
│   └── DynamicProgramming/
├── DataStructures/      # Custom data structure implementations
│   ├── LinkedLists/
│   ├── Trees/
│   ├── Graphs/
│   └── Heaps/
├── DesignPatterns/      # Gang of Four patterns
│   ├── Creational/
│   ├── Structural/
│   └── Behavioral/
├── Exercises/           # Coding challenges
│   ├── LeetCode/
│   ├── HackerRank/
│   └── CustomProblems/
├── LanguageFeatures/    # C# language exploration
│   ├── LINQ/
│   ├── AsyncAwait/
│   ├── Generics/
│   └── Reflection/
├── Utilities/           # Helper classes and extensions
├── Projects/            # Mini-projects
└── Tests/               # Unit tests
```

## 🚀 Getting Started:

### Prerequisites:
-> .NET SDK (version 6.0 or higher)

-> Visual Studio 2022+ or VS Code with C# extensions

-> Basic understanding of C# programming

-> Running the Code

### Clone the repository:
```
git clone https://github.com/yourusername/csharp-practice.git
```

### Navigate to a specific solution:
```
cd CSharp-Practice/Exercises
```
### Build and Run:
```
dotnet build
dotnet run
```
## 🛠️ Technologies Used Here

-> .NET 6/7/8/10 - Cross-platform development framework

-> C# 10/11 - Modern language features

-> xUnit/NUnit - Unit testing frameworks

-> BenchmarkDotNet - Performance benchmarking

-> LINQPad - Interactive C# scratchpad

## 📖 Learning Path:

#### Beginner Level:

-> Basic syntax and control structures

-> Object-Oriented Programming (OOP) principles

-> Collections and generics

-> Exception handling

-> File I/O operations

#### Intermediate Level:

-> Advanced LINQ queries

-> Asynchronous programming (async/await) important

-> Delegates, events, and lambdas

-> Extension methods

-> Reflection and attributes

#### Advanced Level

-> Design patterns implementation

-> Memory management and performance

-> Parallel programming

#### Advanced data structures

-> Algorithm optimization

## 💡 Practice Areas

#### Algorithms:
-> Sorting algorithms (QuickSort, MergeSort, etc.)

-> Search algorithms (Binary, Linear, etc.)

-> Graph algorithms (BFS, DFS, Dijkstra)

-> Dynamic programming problems

-> Recursion and backtracking

#### Data Structures
-> Arrays, Lists, Dictionaries

-> Stacks, Queues, Deques

-> Linked Lists (Singly, Doubly, Circular)

 ->Trees (Binary, AVL, Red-Black)
 
-> Heaps and Priority Queues

## C# Specific Features
-> LINQ to Objects, XML, SQL

-> Async/Await patterns

-> Expression trees

-> Pattern matching

-> Records and init-only properties

-> Source generators

## 🧪 Testing

-> Each implementation includes unit tests to verify correctness:


# Run all tests:
```
dotnet test
```
# Run specific test project:
```
dotnet test ./Tests/AlgorithmTests
```

## 📈 Performance:
Some solutions include benchmarking using BenchmarkDotNet:
```
csharp
[MemoryDiagnoser]
public class SortingBenchmarks
{
    // Benchmark methods here
}
```

## 🤝 Contributing:
Contributions are welcome! Please follow these steps:

Fork the repository

Create a feature branch (git checkout -b feature/AmazingFeature)

Commit changes (git commit -m 'Add AmazingFeature')

Push to branch (git push origin feature/AmazingFeature)

Open a Pull Request

📝 Code Style Guidelines:
Use meaningful variable and method names

Follow C# naming conventions (PascalCase for methods, camelCase for variables)

Add XML documentation comments for public members

Keep methods focused and single-responsibility

Use var when type is obvious from right-hand side

Prefer expression-bodied members for simple methods

## 🔗 Useful Resources:
Microsoft C# Documentation

LeetCode - Coding challenges

Exercism C# Track

C# Programming Yellow Book

## 🏆 Acknowledgments
Inspired by various coding challenge platforms

Thanks to the .NET community for excellent documentation, Algorithm references from CLRS and other classic texts.
