# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy and restore project files
COPY *.csproj ./ 
RUN dotnet restore

# Copy the remaining files and build the application
COPY . ./ 
RUN dotnet publish -c Release -o out

# Stage 2: Run the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build /app/out . 

# Copy the certificate file into the container
COPY ./certificates/httpscert.pfx ./certificates/httpscert.pfx

# Expose the port the application listens on
EXPOSE 5118

# Set the entry point for the application
ENTRYPOINT ["dotnet", "velocitaApi.dll"]
