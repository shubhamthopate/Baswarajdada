#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/CIC_EP.Migrator/CIC_EP.Migrator.csproj", "src/CIC_EP.Migrator/"]
COPY ["src/CIC_EP.EntityFrameworkCore/CIC_EP.EntityFrameworkCore.csproj", "src/CIC_EP.EntityFrameworkCore/"]
COPY ["src/CIC_EP.Core/CIC_EP.Core.csproj", "src/CIC_EP.Core/"]
COPY ["src/CIC_EP.Core.Shared/CIC_EP.Core.Shared.csproj", "src/CIC_EP.Core.Shared/"]
RUN dotnet restore "src/CIC_EP.Migrator/CIC_EP.Migrator.csproj"
COPY . .
WORKDIR "/src/src/CIC_EP.Migrator"
RUN dotnet build "CIC_EP.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CIC_EP.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CIC_EP.Migrator.dll"]
