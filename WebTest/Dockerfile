#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
#WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["WebTest/WebTest.csproj", "WebTest/"]
RUN dotnet restore "WebTest/WebTest.csproj"
COPY . .
WORKDIR "/src/WebTest"
RUN dotnet build "WebTest.csproj" -c Release -o /app/build
ENTRYPOINT ["dotnet", "test"]
#
#FROM build AS publish
#RUN dotnet publish "WebTest.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "WebTest.dll"]