# Getting started

## 1. Install the package
You can install Sharp of Clans via the package manager with the following command:
```
Install-Package SharpOfClans
```

For different installation ways, please refer to the Sharp of Clans [nuget page](https://www.nuget.org/packages/SharpOfClans/).

## 2. Using the library
Import the library with the following line:
`using SharpOfClans;`

After importing, you can get an instance of the API's entrypoint class with:
```csharp
// Replace 'cocApiToken' with your CoC API Token
var cocApiToken = "token";
var clashApi = ClashApi.GetInstance(cocApiToken);
```

You can then use `clashApi` to access the API's endpoints, for example:
```csharp
// Get a player with specific tag through the players endpoint
var player = await clashApi.Players.GetPlayerAsync("#L22YL908");

// Write player's name to the console
Console.WriteLine($"The player's name is {player.Name}.");
```

For a list of endpoints, refer to [SharpOfClans.Endpoints.Interfaces](xref:SharpOfClans.Endpoints.Interfaces).
