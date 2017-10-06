# Writing Hadoop MapReduce Streaming jobs in C# .NET Core 2.0

Repository demonstrating how to uset .NET Core 2.0 C# with Hadoop MapReduce.

This repo will contain the Docker image and C# sources used in my blog post on [codevoid.io](https://codevoid.io).

## Building the C# projects

- Ensure you have [.NET Core 2.0.0 installed](https://github.com/dotnet/core/blob/master/release-notes/download-archives/2.0.0-download.md)
- Navigate the the project you want to build, e.g. `.\dotnet-core-mapreduce\dotnet-core-mapper`.
- Run a `dotnet publish` for the runtime you want to build. E.g., for Ubuntu 14.04, run:
```
dotnet publish --runtime ubuntu.14.04-x64 -c Release
```

You will likely also want Visual Studio 2017 installed, you can download the Community Edition
[here](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15) for free. 

## Building the Docker image 

The docker image uses [sequenceiq/hadoop-ubuntu:2.6.0](https://hub.docker.com/r/sequenceiq/hadoop-ubuntu/~/dockerfile/) image as base, and adds .NET Core 2.0 support.

To build the image, `cd` to `./docker-image` and run:
```
docker build -t hadoop-ubuntu-dotnet .
```

## Running the docker image

```
docker run -it hadoop-ubuntu-dotnet /etc/bootstrap.sh -bash
```

## Datasets

The first dataset used in the blog post is located at `/datasets/reddit_top_100_cat_posts.json`. Since it'sonly used for the proof-of-concept MapReduce app,
it's fairly small - only 100 lines. Each line is a JSON object representing a Reddit thread. 