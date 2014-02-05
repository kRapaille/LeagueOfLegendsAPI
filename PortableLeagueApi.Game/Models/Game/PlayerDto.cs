using Newtonsoft.Json;

namespace PortableLeagueApi.Game.Models.Game
{
    public class PlayerDto
    {
        /// <summary>
        /// Champion id associated with player.
        /// </summary>
        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        /// <summary>
        /// Team id associated with player.
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        /// <summary>
        /// Summoner id associated with player.
        /// </summary>
        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }
}