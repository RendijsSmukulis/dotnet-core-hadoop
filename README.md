# Writing Hadoop MapReduce Streaming jobs in C# .NET Core 2.0

Repository demonstrating how to uset .NET Core 2.0 C# with Hadoop MapReduce.

This repo will contain the Docker image and C# sources used in my article on [codevoid.io](https://codevoid.io).

## Building the C# projects

- Navigate the the project you want to build, e.g. `.\dotnet-core-mapreduce\dotnet-core-mapper`.
- Run a `dotnet publish` for the runtime you want to build. E.g., for Ubuntu 14.04, run:
```
dotnet publish --runtime ubuntu.14.04-x64 -c Release
```
