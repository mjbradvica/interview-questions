# Senior

Explain the basic functions of the C# garbage collector: The garbage collectors main purpose is to clean up references that are no longer being used. It does this by scanning all objects in that heap that no longer have any references and reclaiming those objects

Does C# support the concept of pointers: Yes, you can still have manually managed pointers in C#

If I wanted to use raw pointers, what would I have to do: Enable them in the project settings, then wrap them in the unsafe keyword in code

What does the checked operator do: Tells the runtime to throw an Overflow Exception instead of silently dealing with numeric overflow

What does the term "managed code" mean in relation to the .NET ecosystem: "Manage code" is a term reserved for code that require a runtime environment to run. C#, F#, and VB.NET are all examples of managed code, they are translated into IL (Intermediate Language) that is executed by the JIT (Just-In-Time Compiler) at runtime.

What is the CLR (Common Language Runtime): The CLR is Microsoft's implementation of the CLI (Common Language Interface). It provides language features, threading, exception handling, attributes, and garage collection. It is the primary "virtual machine" for the .NET ecosystem

Can a .NET Standard package reference a .NET Core or Framework package: No, but the opposite is true

What does the params keyword allow you to do with a method: Pass an unlimited number of arguments as an array to a method

