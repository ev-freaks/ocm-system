FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
FROM mcr.microsoft.com/dotnet/core/sdk:3.1.100 AS build

WORKDIR /src
# make sure that the docker context is set to the "API" directory
ADD / ./API
# RUN git clone https://github.com/openchargemap/ocm-system .
# RUN dotnet restore "API/OCM.Net/OCM.API.Worker/OCM.API.Worker.csproj"

WORKDIR /src/API/OCM.Net/OCM.API.Worker
RUN cp ./appsettings.Docker.json ./appsettings.json
RUN dotnet build "OCM.API.Worker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OCM.API.Worker.csproj" -c Release -o /app/publish

FROM base AS final

WORKDIR /app
EXPOSE 80
EXPOSE 443

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OCM.API.Worker.dll"]