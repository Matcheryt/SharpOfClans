using Newtonsoft.Json;

namespace SharpOfClans.Models.Leagues
{
    public class LegendLeagueTournamentSeason
    {
        /// <summary>
        /// Total trophies.
        /// </summary>
        [JsonProperty("trophies")]
        public int Trophies { get; set; }

        /// <summary>
        /// League season id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Player's rank in the season.
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
