## Node.js build stage
#FROM node:alpine AS node-build
#WORKDIR /app
## Copy package.json and package-lock.json to the container
#COPY ./DotNetTribe_UI/package*.json .
## Copy the entire project to the container
#COPY . ./
## Install Node.js dependencies
#RUN ls -la
#RUN npm install
### Run the custom build script for CSS
##RUN npm run buildcss
#
# .NET Core build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
# Install Node.js
RUN apt-get update && \
    apt-get install -y wget && \
    wget -qO- https://deb.nodesource.com/setup_16.x | bash - && \
    apt-get install -y nodejs
# Copy csproj files
COPY ["DotNetTribe_UI/DotNetTribe_UI.csproj", "DotNetTribe_UI/"]
COPY ["DotNetTribe_UI_Services/DotNetTribe_UI_Services.csproj", "DotNetTribe_UI_Services/"]
COPY ["DotNetTribe_UI_Shared/DotNetTribe_UI_Shared.csproj", "DotNetTribe_UI_Shared/"]
# Restore dependencies
RUN dotnet restore "./DotNetTribe_UI/DotNetTribe_UI.csproj"
# Copy everything else and build our release
COPY . ./
WORKDIR "/src/DotNetTribe_UI"

RUN npm install
RUN npm run buildcss
#RUN dotnet build "./DotNetTribe_UI.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish stage
FROM build-env AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish -c $BUILD_CONFIGURATION -o /app/publish

# Runtime environment
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=publish /app/publish .
#COPY --from=node-build /app/wwwroot/css ./wwwroot/css
ENTRYPOINT ["dotnet", "DotNetTribe_UI.dll"]
