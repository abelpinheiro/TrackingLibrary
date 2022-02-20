#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/services/TL.Client.API/TL.Client.API.csproj", "src/services/TL.Client.API/"]
RUN dotnet restore "src/services/TL.Client.API/TL.Client.API.csproj"
COPY . .
WORKDIR "/src/src/services/TL.Client.API"
RUN dotnet build "TL.Client.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TL.Client.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TL.Client.API.dll"]