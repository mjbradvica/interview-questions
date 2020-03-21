# Principle

What is the difference between the CLR and CLI: The CLI (Common Language Infrastructure) is a open-source standard specification developed by Microsoft that describes how a runtime may be implement. It describes the CTS (Common Type System), Metadata, CLS (Common Language Specfication) and VES (Virtual Execution System)

Are there other implementations of the CLI besides CLR: Yes, Mono is the most common alternative implementation. DotGNU, and Portable .NET are other implementations

What are the three rules of definite assignment: Local variables must be assigned before they can be read, function arguments must be assigned when a method is called, and all other variables are automatically initialized by the runtime