#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["OnlineTrainingTracker/OnlineTrainingTracker.csproj", "OnlineTrainingTracker/"]
RUN dotnet restore "OnlineTrainingTracker/OnlineTrainingTracker.csproj"
COPY . .
WORKDIR "/src/OnlineTrainingTracker"
RUN dotnet build "OnlineTrainingTracker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnlineTrainingTracker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnlineTrainingTracker.dll"]