LeagueOfLegendsAPI
==================

Portable C# Library for [League of legends API](https://developer.riotgames.com)

Do not hesitate to reach me on twitter **[@kRapaille](http://www.twitter.com/kRapaille)**

Install
-------

The library is on NuGet. You can find it [here](https://www.nuget.org/packages/Remake.PortableLeagueAPI/).

    PM> Install-Package Remake.PortableLeagueAPI

Init
----
```c#
LeagueAPI.Init("YOUR KEY HERE");
    
// Facultative parameters :
LeagueAPI.DefaultRegion = RegionEnum.Euw;
LeagueAPI.WaitToAvoidRateLimit = true;
```

**Note** : By default the library doesn't check for the rate limit. But if you want to wait when you reach it, you can set the **WaitToAvoidRateLimit** property to true.

Usage
------
```c#
var runePages = await LeagueAPI.Summoner.GetRunePagesBySummonerId(19231046);
```

Disclaimer
----------

This product is not endorsed, certified or otherwise approved in any way by Riot Games, Inc. or any of its affiliates.
