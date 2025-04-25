FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["dotnet-grpc-service/dotnet-grpc-service.csproj", "dotnet-grpc-service/"]
RUN dotnet restore "dotnet-grpc-service/dotnet-grpc-service.csproj"
COPY . .
WORKDIR "/src/dotnet-grpc-service"
RUN dotnet build "dotnet-grpc-service.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "dotnet-grpc-service.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dotnet-grpc-service.dll"]
