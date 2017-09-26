# Builds on top of sequenceiq's hadoop 2.6.0 on Ubuntu 14.04
# by adding .NET Core 2.0.0 support.
#
# docker build -t rendijssmukulis/hadoop-ubuntu-dotnet

FROM sequenceiq/hadoop-ubuntu:2.6.0

RUN curl https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.gpg && \
    mv microsoft.gpg /etc/apt/trusted.gpg.d/microsoft.gpg && \
    sh -c 'echo "deb [arch=amd64] https://packages.microsoft.com/repos/microsoft-ubuntu-trusty-prod trusty main" > /etc/apt/sources.list.d/dotnetdev.list' && \
    apt-get update && \
    apt-get install -y dotnet-sdk-2.0.0

CMD ["/etc/bootstrap.sh", "-d"]
