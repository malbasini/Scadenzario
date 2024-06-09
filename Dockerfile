FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App
#e Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore Scadenzario.sln
# Build and publish a release
RUN dotnet publish Scadenzario.sln -c Release -o out
# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/out .
EXPOSE 8081
ENTRYPOINT ["dotnet", "Scadenzario.dll"]