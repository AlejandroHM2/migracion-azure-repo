#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine3.17 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine3.17 AS build
WORKDIR /src
COPY ["Company.Service.API/Company.Service.API.csproj", "Company.Service.API/"]
COPY ["Company.Service.Backgrounds/Company.Service.Backgrounds.csproj", "Company.Service.Backgrounds/"]
COPY ["Company.Service.DTOs/Company.Service.DTOs.csproj", "Company.Service.DTOs/"]
COPY ["Company.Service.IoC/Company.Service.IoC.csproj", "Company.Service.IoC/"]
COPY ["Company.Service.Repositories/Company.Service.Repositories.csproj", "Company.Service.Repositories/"]
COPY ["Company.Service.Entities/Company.Service.Entities.csproj", "Company.Service.Entities/"]
COPY ["Company.Service.UseCases/Company.Service.UseCases.csproj", "Company.Service.UseCases/"]
COPY ["Company.Service.Presenters/Company.Service.Presenters.csproj", "Company.Service.Presenters/"]
COPY ["Company.Service.WebExceptionsPresenter/Company.Service.WebFilters.csproj", "Company.Service.WebExceptionsPresenter/"]
RUN dotnet restore "Company.Service.API/Company.Service.API.csproj"
COPY . .
WORKDIR "/src/Company.Service.API"
RUN dotnet build "Company.Service.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Company.Service.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 5150
ENTRYPOINT ["dotnet", "Company.Service.API.dll"]