#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Squirrel.API/Squirrel.API.csproj", "Squirrel.API/"]
RUN dotnet restore "Squirrel.API/Squirrel.API.csproj"
COPY . .
WORKDIR "/src/Squirrel.API"
RUN dotnet build "Squirrel.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Squirrel.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Squirrel.API.dll"]