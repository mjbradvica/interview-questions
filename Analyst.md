# Analyst

What does it mean to say that C# is a statically typed language: Type safety is enforced at compile time

Are there non static elements in C#: The dynamic keyword does not enforce compile time type safety

What are some reference types: object, string interface, array, delegate

So a string isn't a value type: It's a reference type that behaves like a value type. String are immutable

What is the difference between the stack and heap: In a traditional sense the stack is managed by the language and compiler, the heap is manually managed. Although in the c# land, all memory is technically managed by the CLR and its garbage collection. Technically there is still some deterministic behavior to the heap in that we get to determine the lifetime of objects to a certain degree

What are the default value and reference types: Reference types default to null, value types are 0 for int, false for bool, DateTime.Min for DateTime, '\0' for char

