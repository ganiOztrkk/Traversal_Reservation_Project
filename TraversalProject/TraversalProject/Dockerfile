FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TraversalProject/TraversalProject.csproj", "TraversalProject/"]
RUN dotnet restore "TraversalProject/TraversalProject.csproj"
COPY . .
WORKDIR "/src/TraversalProject"
RUN dotnet build "TraversalProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TraversalProject.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TraversalProject.dll"]
