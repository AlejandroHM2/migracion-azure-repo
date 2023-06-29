#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine3.17 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine3.17 AS build
WORKDIR /src
COPY ["[%= company %].[%= name %]s.API/[%= company %].[%= name %]s.API.csproj", "[%= company %].[%= name %]s.API/"]
COPY ["[%= company %].[%= name %]s.Backgrounds/[%= company %].[%= name %]s.Backgrounds.csproj", "[%= company %].[%= name %]s.Backgrounds/"]
COPY ["[%= company %].[%= name %]s.DTOs/[%= company %].[%= name %]s.DTOs.csproj", "[%= company %].[%= name %]s.DTOs/"]
COPY ["[%= company %].[%= name %]s.IoC/[%= company %].[%= name %]s.IoC.csproj", "[%= company %].[%= name %]s.IoC/"]
COPY ["[%= company %].[%= name %]s.Repositories/[%= company %].[%= name %]s.Repositories.csproj", "[%= company %].[%= name %]s.Repositories/"]
COPY ["[%= company %].[%= name %]s.Entities/[%= company %].[%= name %]s.Entities.csproj", "[%= company %].[%= name %]s.Entities/"]
COPY ["[%= company %].[%= name %]s.UseCases/[%= company %].[%= name %]s.UseCases.csproj", "[%= company %].[%= name %]s.UseCases/"]
COPY ["[%= company %].[%= name %]s.Presenters/[%= company %].[%= name %]s.Presenters.csproj", "[%= company %].[%= name %]s.Presenters/"]
COPY ["[%= company %].[%= name %]s.WebExceptionsPresenter/[%= company %].[%= name %]s.WebFilters.csproj", "[%= company %].[%= name %]s.WebExceptionsPresenter/"]
RUN dotnet restore "[%= company %].[%= name %]s.API/[%= company %].[%= name %]s.API.csproj"
COPY . .
WORKDIR "/src/[%= company %].[%= name %]s.API"
RUN dotnet build "[%= company %].[%= name %]s.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "[%= company %].[%= name %]s.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE [%= port %]
ENTRYPOINT ["dotnet", "[%= company %].[%= name %]s.API.dll"]