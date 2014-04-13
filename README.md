Portable C# Library for [League of Legends API](https://developer.riotgames.com)

## Install

- Register [here](https://developer.riotgames.com/)

- Install the library from NuGet. You can find it [here](https://www.nuget.org/packages/Remake.PortableLeagueAPI/).

```
PM> Install-Package Remake.PortableLeagueAPI
```

## Example
```c#

var leagueAPI = new LeagueApi("YOUR API KEY HERE", RegionEnum.Euw, true);

var summoner = await _leagueAPI.Summoner.GetSummonerByNameAsync("TuC Ølen");
var recentGames = await summoner.GetRecentGamesAsync();

var item = await _leagueAPI.Static.GetItemsAsync(
  1001, 
  ItemDataEnum.All, 
  languageCode: LanguageEnum.French);
  
var imageUrl = await item.Image.GetUrlAsync();

```

**Note** : By default the library doesn't check for the rate limit. But if you want to wait when you reach it, set the third paramater in the LeagueAPI constructor to true.

## Notes

- If your visual studio puts in red some methods from the API. Please, unload and reload your project from the solution.
- If something doesn't work or isn't up to date. Please, check if there is any available updates on NuGet. If it still doesn't work, [create an issue](https://github.com/XeeX/LeagueOfLegendsAPI/issues/new).


## Status

#### Dev
[![PortableLeagueAPI Build Status](https://www.myget.org/BuildSource/Badge/remake?identifier=dc59073d-2442-452f-829b-d8746868ea58)](https://www.myget.org/feed/Packages/remake)

#### NuGet
[![NuGet version](https://badge.fury.io/nu/Remake.PortableLeagueApi.png)](http://badge.fury.io/nu/Remake.PortableLeagueApi)

## Last changes

- Static API v1.1
- Champion API v1.2
- Stats  API v1.3
- Summoner  API v1.4
- Games API updates
- Static masteries DTOs fix
- All unit tests are now offline
- Accept-Encoding now supports gzip and deflate
- Updated Game Constants to include Team Builder constants.
- Added endpoints to leagues to get a league and a league entry by team ID.
- Async naming convention
- Datetime converter fix

## Disclaimer

This product is not endorsed, certified or otherwise approved in any way by Riot Games, Inc. or any of its affiliates.


## Contact

Do not hesitate to reach me on twitter **[@kRapaille](http://www.twitter.com/kRapaille)** or by **[mail](mailto:myself@kevinrapaille.com)**
