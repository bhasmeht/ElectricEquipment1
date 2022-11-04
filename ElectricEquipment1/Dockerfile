#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
#
#FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
#WORKDIR /src
#COPY ["ElectricEquipment1/ElectricEquipment1.csproj", "ElectricEquipment1/"]
#RUN dotnet restore "ElectricEquipment1/ElectricEquipment1.csproj"
#COPY . .
#WORKDIR "/src/ElectricEquipment1"
#RUN dotnet build "ElectricEquipment1.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "ElectricEquipment1.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "ElectricEquipment1.dll"]
#
# Stage 1
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app
# Stage 2
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS final
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "ElectricEquipment1.dll"]