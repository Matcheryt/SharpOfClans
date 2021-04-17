using Newtonsoft.Json;

namespace SharpOfClans.Models.Rankings
{
    public class PlayerVersusRanking
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
        /// The player's versus trophies.
        /// </summary>
        [JsonProperty("versusTrophies")]
        public int VersusTrophies { get; set; }

        /// <summary>
        /// The player's clan.
        /// </summary>
        [JsonProperty("clan")]
        public PlayerRankingClan Clan { get; set; }

        /// <summary>
        /// The player's total wins in versus battles.
        /// </summary>
        [JsonProperty("versusBattleWins")]
        public int VersusBattleWins { get; set; }
    }
}
