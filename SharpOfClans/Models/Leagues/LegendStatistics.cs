using Newtonsoft.Json;

namespace SharpOfClans.Models.Leagues
{
    public class LegendStatistics
    {
        /// <summary>
        /// Previous legend league season.
        /// </summary>
        [JsonProperty("previousSeason")]
        public LegendLeagueTournamentSeason PreviousSeason { get; set; }

        /// <summary>
        /// Best legend league season.
        /// </summary>
        [JsonProperty("bestSeason")]
        public LegendLeagueTournamentSeason BestSeason { get; set; }

        /// <summary>
        /// Best versus legend league season.
        /// </summary>
        [JsonProperty("bestVersusSeason")]
        public LegendLeagueTournamentSeason BestVersusSeason { get; set; }

        /// <summary>
        /// Current legend season.
        /// </summary>
        [JsonProperty("currentSeason")]
        public LegendLeagueTournamentSeason CurrentSeason { get; set; }

        /// <summary>
        /// Previous versus legend league season.
        /// </summary>
        [JsonProperty("previousVersusSeason")]
        public LegendLeagueTournamentSeason PreviousVersusSeason { get; set; }

        /// <summary>
        /// Total legend trophies.
        /// </summary>
        [JsonProperty("legendTrophies")]
        public int LegendTrophies { get; set; }
    }
}
