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
# Build stage
# Build stage
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
#ARG BUILD_CONFIGURATION=Release
#WORKDIR /src
#
## Install Node.js
#RUN apt-get update && \
    #apt-get install -y wget && \
    #wget -qO- https://deb.nodesource.com/setup_16.x | bash - && \
    #apt-get install -y nodejs
#
## Copy csproj files and restore dependencies
#COPY ["DotNetTribe_UI/DotNetTribe_UI.csproj", "DotNetTribe_UI/"]
#COPY ["DotNetTribe_UI_Services/DotNetTribe_UI_Services.csproj", "DotNetTribe_UI_Services/"]
#COPY ["DotNetTribe_UI_Shared/DotNetTribe_UI_Shared.csproj", "DotNetTribe_UI_Shared/"]
#RUN dotnet restore "./DotNetTribe_UI/DotNetTribe_UI.csproj"
#
## Copy the rest of the application code
#COPY . .
#
## Build and publish the project
#WORKDIR "/src/DotNetTribe_UI"
#RUN npm install
#RUN npm run buildcss
#RUN dotnet publish -c $BUILD_CONFIGURATION -o /app/publish
#
## Runtime environment
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
#WORKDIR /app
#COPY --from=build-env /app/publish .
#
## Ensure the DLL exists
#RUN ls -al
#
## Entry point
#ENTRYPOINT ["dotnet", "DotNetTribe_UI.dll"]

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build-env
WORKDIR /app

# Install Node.js and npm
RUN apk add --no-cache nodejs npm

# Copy all files
COPY . ./

# Install npm dependencies for CommonComponents
RUN npm --prefix DotNetTribe_UI install

# Publish the .NET project to the output directory
RUN dotnet publish "DotNetTribe_UI/DotNetTribe_UI.csproj" -c Release -o output

# Runtime stage with Nginx
FROM nginx:alpine
WORKDIR /usr/share/nginx/html

# Copy the build output to the Nginx web root
COPY --from=build-env /app/output/wwwroot .

# Copy custom Nginx configuration
COPY DotNetTribe_UI/nginx.conf /etc/nginx/nginx.conf

# Expose port 80
EXPOSE 80

# Start Nginx
CMD ["nginx", "-g", "daemon off;"]

