Add readme to Hair Salon

-include the production database for appsettings.json

make url strings lowercase


old property group below from HairSalon.csproj
<PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  -note for the readme you use incorrect DAtatype in sql used a Varchar not in causing problems
-you also did not pass the model to the view
-need to click apply to update data
-DELETE FROM `dan_kiss`.`Clients` WHERE (`ClientId` = '1');