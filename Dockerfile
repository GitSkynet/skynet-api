# See https://aka.ms/containerfastmode to understand how Visual Studio
# uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WebApi/WebApi.csproj", "WebApi/"]
COPY ["CleanArchitecture.Application/CleanArchitecture.Application.csproj", "CleanArchitecture.Application/"]
COPY ["DomainService.Contracts/DomainService.Contracts.csproj", "DomainService.Contracts/"]
COPY ["DtoService/DtoService.csproj", "DtoService/"]
COPY ["Entities/Entities.csproj", "Entities/"]
COPY ["Repository.Contracts/Repository.Contracts.csproj", "Repository.Contracts/"]
COPY ["DataContext/DataContext.csproj", "DataContext/"]
COPY ["DomainService/DomainService.csproj", "DomainService/"]
COPY ["Dto.Mappings/Dto.Mappings.csproj", "Dto.Mappings/"]
COPY ["Repositories/Repositories.csproj", "Repositories/"]
COPY ["DataAccess/DataAccess.csproj", "DataAccess/"]
RUN dotnet restore "WebApi/WebApi.csproj"
COPY . .
WORKDIR "/src/WebApi"
RUN dotnet build "WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
LABEL maintainer="Carlos Curtido"
LABEL org.opencontainers.image.source="https://github.com/GitSkynet/APICleanArchitecture"
LABEL org.opencontainers.image.title="API Curtido Clean Architecture"
LABEL org.opencontainers.image.description="General API"
LABEL org.opencontainers.image.revision="1"
LABEL org.opencontainers.image.vendor="Ciberdyne Systems"
LABEL org.opencontainers.image.licenses="Open Source"
LABEL org.opencontainers.image.restarts=always
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApi.dll"]