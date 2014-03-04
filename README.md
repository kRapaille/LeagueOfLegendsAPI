Portable C# Library for [League of Legends API](https://developer.riotgames.com)

[![PortableLeagueAPI Build Status](https://www.myget.org/BuildSource/Badge/remake?identifier=dc59073d-2442-452f-829b-d8746868ea58)](https://www.myget.org/feed/Packages/remake)

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

## Last changes

- Async naming convention
- Datetime converter fix

## Disclaimer

This product is not endorsed, certified or otherwise approved in any way by Riot Games, Inc. or any of its affiliates.


## Contact

Do not hesitate to reach me on twitter **[@kRapaille](http://www.twitter.com/kRapaille)** or by **[mail](mailto:myself@kevinrapaille.com)**
