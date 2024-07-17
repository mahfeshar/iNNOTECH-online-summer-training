# Session 3 Tasks
1. Different between abstract class & Sealed class <br>
    Different between struct & class <br>
    Different between record & class
---
2. Class is mutable or immutable? <br>
    and how to change it?
---
3. What  is tuple? <br>
    and how to use it?
---
### 1. Differences

#### Abstract Class vs Sealed Class

- **Abstract Class**
  - Cannot be instantiated directly.
  - Must be inherited by other classes.
  - Can contain abstract methods (without implementation).
  - Can contain concrete methods and properties.
  - Used to define a base class with shared behavior.

- **Sealed Class**
  - Can be instantiated directly.
  - Cannot be inherited by other classes.
  - Cannot contain abstract methods.
  - Can contain only concrete methods and properties.
  - Used to prevent further inheritance.

#### Struct vs Class

- **Struct**
  - Value type.
  - Allocated on the stack.
  - Cannot inherit from other structs or classes.
  - Cannot have a parameterless constructor (before C# 10).
  - Suitable for small, simple data structures.

- **Class**
  - Reference type.
  - Allocated on the heap.
  - Can inherit from other classes.
  - Can have parameterless constructors.
  - Suitable for complex objects with behavior.

#### Record vs Class

- **Record**
  - Immutable by default (can be made mutable).
  - Uses value-based equality.
  - Can inherit other records and be inherited.
  - Suitable for data models and immutable data structures.

- **Class**
  - Mutable by default (can be made immutable).
  - Uses reference-based equality.
  - Can inherit other classes and be inherited.
  - Suitable for complex objects with mutable state.

### 2. Class Mutability

#### Is a Class Mutable or Immutable?

- By default, classes in C# are mutable, meaning their state can be changed after they are created.

#### How to Make a Class Immutable

- To make a class immutable:
  - Make all fields or properties readonly.
  - Provide no setters.
  - Initialize these fields/properties via the constructor.

*Example:*

```csharp
public class Student
{
    public int Id { get; }
    public string Name { get; }
    public string Class { get; }

    public Student(int id, string name, string @class)
    {
        Id = id;
        Name = name;
        Class = @class;
    }
}
```

### 3. Tuple

#### What is a Tuple?

- A tuple is a data structure that can store a fixed number of elements of potentially different types. It groups multiple values together without creating a specific class or struct.

#### How to Use a Tuple

- **Using the Tuple class:**

```csharp
var person = Tuple.Create("John", 30, "Engineer");

Console.WriteLine(person.Item1); // John
Console.WriteLine(person.Item2); // 30
Console.WriteLine(person.Item3); // Engineer
```

- **Using tuple syntax:**

```csharp
var person = ("John", 30, "Engineer");

Console.WriteLine(person.Item1); // John
Console.WriteLine(person.Item2); // 30
Console.WriteLine(person.Item3); // Engineer
```

- **Using named elements:**

```csharp
var person = (Name: "John", Age: 30, Occupation: "Engineer");

Console.WriteLine(person.Name); // John
Console.WriteLine(person.Age);  // 30
Console.WriteLine(person.Occupation); // Engineer
```
