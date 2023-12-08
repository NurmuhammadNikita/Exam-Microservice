#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/General-Motors/General-Motors.API/General-Motors.API.csproj", "src/General-Motors/General-Motors.API/"]
COPY ["src/General-Motors/General-Motors.Application/General-Motors.Application.csproj", "src/General-Motors/General-Motors.Application/"]
COPY ["src/General-Motors/General-Motors.Domain/General-Motors.Domain.csproj", "src/General-Motors/General-Motors.Domain/"]
COPY ["src/General-Motors/General-Motors.Infrastructure/General-Motors.Infrastructure.csproj", "src/General-Motors/General-Motors.Infrastructure/"]
RUN dotnet restore "./src/General-Motors/General-Motors.API/./General-Motors.API.csproj"
COPY . .
WORKDIR "/src/src/General-Motors/General-Motors.API"
RUN dotnet build "./General-Motors.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./General-Motors.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "General-Motors.API.dll"]