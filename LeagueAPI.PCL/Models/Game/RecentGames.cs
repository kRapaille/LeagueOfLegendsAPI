using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Game
{
    public class RecentGamesRoot
    {
        /// <summary>
        /// List of recent games played (max 10).
        /// </summary>
        [JsonProperty("games")]
        public Game[] Games { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

    public class Game
    {
        /// <summary>
        /// Other players associated with the game.
        /// </summary>
        [JsonProperty("fellowPlayers")]
        public Fellowplayer[] FellowPlayers { get; set; }

        /// <summary>
        /// Game type. (legal values: CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)
        /// </summary>
        [JsonProperty("gameType")]
        public string GameType { get; set; }

        /// <summary>
        /// Game ID.
        /// </summary>
        [JsonProperty("gameId")]
        public int GameId { get; set; }

        /// <summary>
        /// ID of first summoner spell.
        /// </summary>
        [JsonProperty("spell1")]
        public int Spell1 { get; set; }

        /// <summary>
        /// Team ID associated with game.
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        /// <summary>
        /// Statistics associated with the game for this summoner.
        /// </summary>
        [JsonProperty("stats")]
        public Statistic Statistics { get; set; }

        /// <summary>
        /// ID of second summoner spell.
        /// </summary>
        [JsonProperty("spell2")]
        public int Spell2 { get; set; }

        /// <summary>
        /// Game mode. (legal values: CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, FIRSTBLOOD)
        /// </summary>
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        /// <summary>
        /// Map ID.
        /// </summary>
        [JsonProperty("mapId")]
        public int MapId { get; set; }

        /// <summary>
        /// Level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Invalid flag.
        /// </summary>
        [JsonProperty("invalid")]
        public bool Invalid { get; set; }

        /// <summary>
        /// Game sub-type. (legal values: NONE, NORMAL, BOT, RANKED_SOLO_5x5, RANKED_PREMADE_3x3, RANKED_PREMADE_5x5, ODIN_UNRANKED, RANKED_TEAM_3x3, RANKED_TEAM_5x5, NORMAL_3x3, BOT_3x3, ARAM_UNRANKED_5x5, ONEFORALL_5x5, FIRSTBLOOD_1x1, FIRSTBLOOD_2x2)
        /// </summary>
        [JsonProperty("subType")]
        public string SubType { get; set; }

        /// <summary>
        /// Champion ID associated with game.
        /// </summary>
        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        /// <summary>
        /// Date that end game data was recorded, specified as epoch milliseconds.
        /// </summary>
        [JsonProperty("createDate")]
        public long CreateDate { get; set; }

        /// <summary>
        /// Human readable string representing date that end game data was recorded.
        /// </summary>
        [JsonProperty("createDateStr")]
        public long CreateDateStr { get; set; }
    }

    public class Fellowplayer
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

    public class Statistic
    {
        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("barracksKilled")]
        public int BarracksKilled { get; set; }

        [JsonProperty("championsKilled")]
        public int ChampionsKilled { get; set; }

        [JsonProperty("combatPlayerScore")]
        public int CombatPlayerScore { get; set; }

        [JsonProperty("consumablesPurchased")]
        public int ConsumablesPurchased { get; set; }

        [JsonProperty("damageDealtPlayer")]
        public int DamageDealtPlayer { get; set; }

        [JsonProperty("doubleKills")]
        public int DoubleKills { get; set; }

        [JsonProperty("firstBlood")]
        public int FirstBlood { get; set; }

        [JsonProperty("gold")]
        public int Gold { get; set; }

        [JsonProperty("goldEarned")]
        public int GoldEarned { get; set; }

        [JsonProperty("goldSpent")]
        public int GoldSpent { get; set; }

        [JsonProperty("item0")]
        public int Item0 { get; set; }

        [JsonProperty("item1")]
        public int Item1 { get; set; }

        [JsonProperty("item2")]
        public int Item2 { get; set; }

        [JsonProperty("item3")]
        public int Item3 { get; set; }

        [JsonProperty("item4")]
        public int Item4 { get; set; }

        [JsonProperty("item5")]
        public int Item5 { get; set; }

        [JsonProperty("item6")]
        public int Item6 { get; set; }

        [JsonProperty("itemsPurchased")]
        public int ItemsPurchased { get; set; }

        [JsonProperty("killingSprees")]
        public int KillingSprees { get; set; }

        [JsonProperty("largestCriticalStrike")]
        public int LargestCriticalStrike { get; set; }

        [JsonProperty("largestKillingSpree")]
        public int LargestKillingSpree { get; set; }

        [JsonProperty("largestMultiKill")]
        public int LargestMultiKill { get; set; }

        /// <summary>
        /// Number of tier 3 items built.
        /// </summary>
        [JsonProperty("legendaryItemsCreated")]
        public int LegendaryItemsCreated { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("magicDamageDealtPlayer")]
        public int MagicDamageDealtPlayer { get; set; }

        [JsonProperty("magicDamageDealtToChampions")]
        public int MagicDamageDealtToChampions { get; set; }

        [JsonProperty("magicDamageTaken")]
        public int MagicDamageTaken { get; set; }

        [JsonProperty("minionsDenied")]
        public int MinionsDenied { get; set; }

        [JsonProperty("minionsKilled")]
        public int MinionsKilled { get; set; }

        [JsonProperty("neutralMinionsKilled")]
        public int NeutralMinionsKilled { get; set; }

        [JsonProperty("neutralMinionsKilledEnemyJungle")]
        public int NeutralMinionsKilledEnemyJungle { get; set; }

        [JsonProperty("neutralMinionsKilledYourJungle")]
        public int NeutralMinionsKilledYourJungle { get; set; }

        /// <summary>
        /// Flag specifying if the summoner got the killing blow on the nexus.
        /// </summary>
        [JsonProperty("nexusKilled")]
        public bool NexusKilled { get; set; }

        [JsonProperty("nodeCapture")]
        public int NodeCapture { get; set; }

        [JsonProperty("nodeCaptureAssist")]
        public int NodeCaptureAssist { get; set; }

        [JsonProperty("nodeNeutralize")]
        public int NodeNeutralize { get; set; }

        [JsonProperty("nodeNeutralizeAssist")]
        public int NodeNeutralizeAssist { get; set; }

        [JsonProperty("numDeaths")]
        public int NumDeaths { get; set; }

        [JsonProperty("numItemsBought")]
        public int NumItemsBought { get; set; }

        [JsonProperty("objectivePlayerScore")]
        public int ObjectivePlayerScore { get; set; }

        [JsonProperty("pentaKills")]
        public int PentaKills { get; set; }

        [JsonProperty("physicalDamageDealtPlayer")]
        public int PhysicalDamageDealtPlayer { get; set; }

        [JsonProperty("physicalDamageDealtToChampions")]
        public int PhysicalDamageDealtToChampions { get; set; }

        [JsonProperty("physicalDamageTaken")]
        public int PhysicalDamageTaken { get; set; }

        [JsonProperty("quadraKills")]
        public int QuadraKills { get; set; }

        [JsonProperty("sightWardsBought")]
        public int SightWardsBought { get; set; }

        /// <summary>
        /// Number of times first champion spell was cast.
        /// </summary>
        [JsonProperty("spell1Cast")]
        public int Spell1Cast { get; set; }

        /// <summary>
        /// Number of times second champion spell was cast.
        /// </summary>
        [JsonProperty("spell2Cast")]
        public int Spell2Cast { get; set; }

        /// <summary>
        /// Number of times third champion spell was cast.
        /// </summary>
        [JsonProperty("spell3Cast")]
        public int Spell3Cast { get; set; }

        /// <summary>
        /// Number of times fourth champion spell was cast.
        /// </summary>
        [JsonProperty("spell4Cast")]
        public int Spell4Cast { get; set; }

        [JsonProperty("summonSpell1Cast")]
        public int SummonSpell1Cast { get; set; }

        [JsonProperty("summonSpell2Cast")]
        public int SummonSpell2Cast { get; set; }

        [JsonProperty("superMonsterKilled")]
        public int SuperMonsterKilled { get; set; }

        [JsonProperty("team")]
        public int Team { get; set; }

        [JsonProperty("teamObjective")]
        public int TeamObjective { get; set; }

        [JsonProperty("timePlayed")]
        public int TimePlayed { get; set; }

        [JsonProperty("totalDamageDealt")]
        public int TotalDamageDealt { get; set; }

        [JsonProperty("totalDamageDealtToChampions")]
        public int TotalDamageDealtToChampions { get; set; }

        [JsonProperty("totalDamageTaken")]
        public int TotalDamageTaken { get; set; }

        [JsonProperty("totalHeal")]
        public int TotalHeal { get; set; }

        [JsonProperty("totalPlayerScore")]
        public int TotalPlayerScore { get; set; }

        [JsonProperty("totalScoreRank")]
        public int TotalScoreRank { get; set; }

        [JsonProperty("totalTimeCrowdControlDealt")]
        public int TotalTimeCrowdControlDealt { get; set; }

        [JsonProperty("totalUnitsHealed")]
        public int TotalUnitsHealed { get; set; }

        [JsonProperty("tripleKills")]
        public int TripleKills { get; set; }

        [JsonProperty("trueDamageDealtPlayer")]
        public int TrueDamageDealtPlayer { get; set; }

        [JsonProperty("trueDamageDealtToChampions")]
        public int TrueDamageDealtToChampions { get; set; }

        [JsonProperty("trueDamageTaken")]
        public int TrueDamageTaken { get; set; }

        [JsonProperty("turretsKilled")]
        public int TurretsKilled { get; set; }

        [JsonProperty("unrealKills")]
        public int UnrealKills { get; set; }

        [JsonProperty("victoryPointTotal")]
        public int VictoryPointTotal { get; set; }

        [JsonProperty("visionWardsBought")]
        public int VisionWardsBought { get; set; }

        [JsonProperty("wardKilled")]
        public int WardKilled { get; set; }

        [JsonProperty("wardPlaced")]
        public int WardPlaced { get; set; }

        /// <summary>
        /// Flag specifying whether or not this game was won.
        /// </summary>
        [JsonProperty("win")]
        public bool Win { get; set; }
    }
}
