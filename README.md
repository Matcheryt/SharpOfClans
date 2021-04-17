# Sharp Of Clans [![build status](https://github.com/Matcheryt/SharpOfClans/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Matcheryt/SharpOfClans/actions) [![Nuget](https://img.shields.io/nuget/v/SharpOfClans)](https://www.nuget.org/packages/SharpOfClans/)
#### A Clash Of Clans API Wrapper for .NET 5.0
##### Inspired by [CocNET](https://github.com/smietanka/CocNET) and [RiotSharp](https://github.com/BenFradet/RiotSharp)

<br/>

This project is licensed under the [MIT license](https://github.com/Matcheryt/SharpOfClans/blob/master/LICENSE).

If you have any questions regarding the library's endpoint structure, please refer to the [Clash of Clans API documentation](https://developer.clashofclans.com/#/documentation).

## Remarks
As of now, this library does not have neither rate limiting nor caching. However, these functionality may be implemented in a future version.

## Adding to your project
You can install Sharp of Clans via the package manager with the following command:
```
Install-Package SharpOfClans
```

For different installation ways, please refer to the Sharp of Clans [nuget page](https://www.nuget.org/packages/SharpOfClans/).

## Using the library
Make sure you're importing the library with `using`:

```csharp
using SharpOfClans;
```

After that, you can get an instance of the entrypoint's class.
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

## Dependencies
- [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)
- [RestSharp](https://github.com/restsharp/RestSharp)

## Credits
This is the first library I developed, hence I had no idea of how one should be structured. For that reason I referred to the [RiotSharp](https://github.com/BenFradet/RiotSharp) library to get an idea of how a library should be structured, so thanks Ben!

## Disclaimer
This material is unofficial and is not endorsed by Supercell. For more information see Supercell's Fan Content Policy: www.supercell.com/fan-content-policy.
