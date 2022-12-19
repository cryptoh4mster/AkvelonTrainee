FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Akvelon.WebApi/Akvelon.WebApi.csproj", "Akvelon.WebApi/"]
COPY ["Akvelon.Business/Akvelon.Business.csproj", "Akvelon.Business/"]
COPY ["Akvelon.Core/Akvelon.DTO/Akvelon.DTO.csproj", "Akvelon.Core/Akvelon.DTO/"]
COPY ["Akvelon.Core/Akvelon.Core/Akvelon.Core.csproj", "Akvelon.Core/Akvelon.Core/"]
COPY ["Akvelon.DAL/Akvelon.DAL.csproj", "Akvelon.DAL/"]
RUN dotnet restore "Akvelon.WebApi/Akvelon.WebApi.csproj"
COPY . .

RUN dotnet build "Akvelon.WebApi/Akvelon.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Akvelon.WebApi/Akvelon.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Akvelon.WebApi.dll"]