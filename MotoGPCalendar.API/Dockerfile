FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MotoGPCalendar.API.csproj", ""]
RUN dotnet restore "MotoGPCalendar.API.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "MotoGPCalendar.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MotoGPCalendar.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MotoGPCalendar.API.dll"]