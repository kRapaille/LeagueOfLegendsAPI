using Newtonsoft.Json;

namespace PortableLeagueApi.Game.Models.DTO
{
    internal class RecentGamesDto
    {
        [JsonProperty("games")]
        public GameDto[] Games { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }

    internal class GameDto
    {
        [JsonProperty("fellowPlayers")]
        public PlayerDto[] FellowPlayers { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("gameId")]
        public int GameId { get; set; }

        [JsonProperty("spell1")]
        public int SummonerSpell1 { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("stats")]
        public RawStatsDto Stats { get; set; }

        [JsonProperty("spell2")]
        public int SummonerSpell2 { get; set; }

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("ipEarned")]
        public int IpEarned { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("invalid")]
        public bool Invalid { get; set; }

        [JsonProperty("subType")]
        public string SubType { get; set; }

        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        [JsonProperty("createDate")]
        public long CreateDate { get; set; }
    }
}
