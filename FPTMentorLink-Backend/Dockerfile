FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["FPTMentorLink-Backend/FPTMentorLink-Backend.csproj", "FPTMentorLink-Backend/"]
RUN dotnet restore "FPTMentorLink-Backend/FPTMentorLink-Backend.csproj"
COPY . .
WORKDIR "/src/FPTMentorLink-Backend"
RUN dotnet build "FPTMentorLink-Backend.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "FPTMentorLink-Backend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FPTMentorLink-Backend.dll"]
