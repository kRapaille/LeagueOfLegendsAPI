using Newtonsoft.Json;
using PortableLeagueApi.Interfaces;

namespace PortableLeagueApi.Game.Models.Game
{
    public class PlayerDto : IChampion, ISummoner
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
        public long SummonerId { get; set; }
    }
}