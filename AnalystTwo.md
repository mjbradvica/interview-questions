# Analyst Two

What is the difference between a double and decimal, when should I use one or the other: Double is base 2, decimal is base 10, use decimal for monetary reasons, otherwise use a double

What is the difference between the .NET Framework and .NET Core: Core is a modern runtime that was designed to be runnable on Linus, iOS, and Windows. It was designed as the successor to the .NET Framework

What are .NET Standard packages: Assemblies that can execute in either .NET Framework or .NET Core projects

What is IL (Intermediate Language): IL or MSIL is what C#, F#, or VB.NET will be converted into by the CLR. It is a common language upon which all .NET language are first converted to. The JIT compiler will then translate the IL to machine code at runtime

What is the difference between implicit and explicit conversion: Implicit conversion  always succeeds and information won't be lost. Explicit casting may fail and information may be lost

What is the difference between an Array, ArrayList, and List<T>: Arrays are static but fixed size, ArrayLists are boxed but not fixed, Lists are static and resize dynamically

How would I pass a value type by reference: Use the ref keyword

What is the purpose of the StringBuilder class: Use StringBuilder when you need to concat or work with lot of strings, it's has better performance that raw strings

How do optional method parameters work: You specify a default value for a method that can be overridden by calling the method normally