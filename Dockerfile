FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY McpServer/McpServer.csproj McpServer/
RUN dotnet restore McpServer/McpServer.csproj

COPY McpServer/ McpServer/
WORKDIR /src/McpServer

RUN dotnet publish McpServer.csproj -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "McpServer.dll"]