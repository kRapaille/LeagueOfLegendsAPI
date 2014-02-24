using Newtonsoft.Json;

namespace PortableLeagueApi.Game.Models.DTO
{
    internal class RecentGamesDto
    {
        [JsonProperty("games")]
        internal GameDto[] Games { get; set; }

        [JsonProperty("summonerId")]
        internal long SummonerId { get; set; }
    }

    internal class GameDto
    {
        [JsonProperty("fellowPlayers")]
        internal PlayerDto[] FellowPlayers { get; set; }

        [JsonProperty("gameType")]
        internal string GameType { get; set; }

        [JsonProperty("gameId")]
        internal int GameId { get; set; }

        [JsonProperty("spell1")]
        internal int SummonerSpell1 { get; set; }

        [JsonProperty("teamId")]
        internal int TeamId { get; set; }

        [JsonProperty("stats")]
        internal RawStatsDto Stats { get; set; }

        [JsonProperty("spell2")]
        internal int SummonerSpell2 { get; set; }

        [JsonProperty("gameMode")]
        internal string GameMode { get; set; }

        [JsonProperty("mapId")]
        internal int MapId { get; set; }

        [JsonProperty("level")]
        internal int Level { get; set; }

        [JsonProperty("invalid")]
        internal bool Invalid { get; set; }

        [JsonProperty("subType")]
        internal string SubType { get; set; }

        [JsonProperty("championId")]
        internal int ChampionId { get; set; }

        [JsonProperty("createDate")]
        internal long CreateDate { get; set; }
    }
}
