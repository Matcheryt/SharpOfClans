using Newtonsoft.Json;
using SharpOfClans.Models.Leagues;

namespace SharpOfClans.Models.Rankings
{
    public class PlayerRanking
    {
        /// <summary>
        /// The player's tag.
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// The player's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The player's level.
        /// </summary>
        [JsonProperty("expLevel")]
        public int ExpLevel { get; set; }

        /// <summary>
        /// The player's current trophies.
        /// </summary>
        [JsonProperty("trophies")]
        public int Trophies { get; set; }

        /// <summary>
        /// The player's total attack wins.
        /// </summary>
        [JsonProperty("attackWins")]
        public int AttackWins { get; set; }

        /// <summary>
        /// The player's total defense wins.
        /// </summary>
        [JsonProperty("defenseWins")]
        public int DefenseWins { get; set; }

        /// <summary>
        /// The player's ranking position.
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }

        /// <summary>
        /// The player's previous ranking position.
        /// </summary>
        [JsonProperty("previousRank")]
        public int PreviousRank { get; set; }

        /// <summary>
        /// The player's clan.
        /// </summary>
        [JsonProperty("clan")]
        public PlayerRankingClan Clan { get; set; }

        /// <summary>
        /// The player's league.
        /// </summary>
        [JsonProperty("league")]
        public League League { get; set; }
    }
}
