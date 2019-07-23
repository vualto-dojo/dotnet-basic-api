FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["something.less.api/something.less.api.csproj", "something.less.api/"]
RUN dotnet restore "something.less.api/something.less.api.csproj"
COPY . .
WORKDIR "/src/something.less.api"
RUN dotnet build "something.less.api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "something.less.api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "something.less.api.dll"]