# Imagen no optimizada para ambiente productivo
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env 
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore 

# Copy everything else and build 
COPY . ./
RUN dotnet publish -c Relaese -o out 

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet","alizen.dll"]
