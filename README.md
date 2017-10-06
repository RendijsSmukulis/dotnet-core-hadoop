# Writing Hadoop MapReduce Streaming jobs in C# .NET Core 2.0

Repository demonstrating how to uset .NET Core 2.0 C# with Hadoop MapReduce.

This repo will contain the Docker image and C# sources used in my article on [codevoid.io](https://codevoid.io).

## Building the C# projects

- If you're building on your host machine (not inside the Docker image), make sure you have [.NET Core 2.0.0 installed](https://github.com/dotnet/core/blob/master/release-notes/download-archives/2.0.0-download.md)
- Navigate the the project you want to build, e.g. `.\dotnet-core-mapreduce\dotnet-core-mapper`.
- Run a `dotnet publish` for the runtime you want to build. E.g., for Ubuntu 14.04, run:
```
dotnet publish --runtime ubuntu.14.04-x64 -c Release
```

## Building the Docker image 

The docker image uses [sequenceiq/hadoop-ubuntu:2.6.0](https://hub.docker.com/r/sequenceiq/hadoop-ubuntu/~/dockerfile/) image as base, and adds .NET Core 2.0 support.

To build the image, `cd` to `./docker-image` and run:
```
docker build -t hadoop-ubuntu-dotnet .
```

## Running the Docker image

To run the image without mounting any volumes, run:
```
docker run -it hadoop-ubuntu-dotnet /etc/bootstrap.sh -bash
```

To have access to the code and sample data that's in this repo, mount the repo as a volume:

```
docker run -v %CD%:/dotnet-core-hadoop -it hadoop-ubuntu-dotnet /etc/bootstrap.sh -bash
```
under Windows, or 
```
docker run -v $(pwd):/dotnet-core-hadoop -it hadoop-ubuntu-dotnet /etc/bootstrap.sh -bash
```
under Mac/Linux.
