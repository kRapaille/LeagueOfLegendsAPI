using Newtonsoft.Json;

namespace LeagueAPI.PCL.Models
{
    public class RecentGamesRoot
    {
        [JsonProperty("games")]
        public Game[] Games { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

    public class Game
    {
        [JsonProperty("fellowPlayers")]
        public Fellowplayer[] FellowPlayers { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("gameId")]
        public int GameId { get; set; }

        [JsonProperty("spell1")]
        public int Spell1 { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("statistics")]
        public Statistic[] Statistics { get; set; }

        [JsonProperty("spell2")]
        public int Spell2 { get; set; }

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("mapId")]
        public int MapId { get; set; }

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

        [JsonProperty("createDateStr")]
        public long CreateDateStr { get; set; }
    }

    public class Fellowplayer
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

    public class Statistic
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
