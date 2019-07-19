FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["something-less/something-less.csproj", "something-less/"]
RUN dotnet restore "something-less/something-less.csproj"
COPY . .
WORKDIR "/src/something-less"
RUN dotnet build "something-less.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "something-less.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "something-less.dll"]