#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["WebSUT/WebSUT.csproj", "WebSUT/"]
RUN dotnet restore "WebSUT/WebSUT.csproj"
COPY . .
WORKDIR "/src/WebSUT"
RUN dotnet build "WebSUT.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebSUT.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebSUT.dll"]