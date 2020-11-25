#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/CIC_EP.Web.Public/CIC_EP.Web.Public.csproj", "src/CIC_EP.Web.Public/"]
COPY ["src/CIC_EP.Web.Core/CIC_EP.Web.Core.csproj", "src/CIC_EP.Web.Core/"]
COPY ["src/CIC_EP.Application/CIC_EP.Application.csproj", "src/CIC_EP.Application/"]
COPY ["src/CIC_EP.Application.Shared/CIC_EP.Application.Shared.csproj", "src/CIC_EP.Application.Shared/"]
COPY ["src/CIC_EP.Core.Shared/CIC_EP.Core.Shared.csproj", "src/CIC_EP.Core.Shared/"]
COPY ["src/CIC_EP.Core/CIC_EP.Core.csproj", "src/CIC_EP.Core/"]
COPY ["src/CIC_EP.EntityFrameworkCore/CIC_EP.EntityFrameworkCore.csproj", "src/CIC_EP.EntityFrameworkCore/"]
COPY ["src/CIC_EP.GraphQL/CIC_EP.GraphQL.csproj", "src/CIC_EP.GraphQL/"]
RUN dotnet restore "src/CIC_EP.Web.Public/CIC_EP.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/CIC_EP.Web.Public"
RUN dotnet build "CIC_EP.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CIC_EP.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CIC_EP.Web.Public.dll"]
