LeagueOfLegendsAPI
==================

Portable C# Library for League of legends API

[Riot dev website](https://developer.riotgames.com)

Do not hesitate to reach me on twitter [@kRapaille](http://www.twitter.com/kRapaille)

Install
-------

The library is on NuGet. You can find it [here](https://www.nuget.org/packages/Remake.PortableLeagueAPI/).

    PM> Install-Package Remake.PortableLeagueAPI

Init
----

    LeagueAPI.Init("YOUR KEY HERE");
    LeagueAPI.SetDefaultRegion(RegionEnum.Euw);

Usage
------

    var runePages = await LeagueAPI.Summoner.GetRunePagesBySummonerId(19231046);
