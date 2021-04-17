using Newtonsoft.Json;
using SharpOfClans.Models.Common;
using SharpOfClans.Models.Locations;

namespace SharpOfClans.Models.Rankings
{
    public class ClanRanking
    {
        /// <summary>
        /// The clan's tag.
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// The clan's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The clan's location.
        /// </summary>
        [JsonProperty("location")]
        public Location Location { get; set; }

        /// <summary>
        /// The clan's badges urls.
        /// </summary>
        [JsonProperty("badgeUrls")]
        public BadgeUrls BadgeUrls { get; set; }

        /// <summary>
        /// The clan's level.
        /// </summary>
        [JsonProperty("clanLevel")]
        public int ClanLevel { get; set; }

        /// <summary>
        /// The clan's total members.
        /// </summary>
        [JsonProperty("members")]
        public int Members { get; set; }

        /// <summary>
        /// The clan's points.
        /// </summary>
        [JsonProperty("clanPoints")]
        public int ClanPoints { get; set; }

        /// <summary>
        /// The clan's ranking position.
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }

        /// <summary>
        /// The clan's previous ranking position.
        /// </summary>
        [JsonProperty("previousRank")]
        public int PreviousRank { get; set; }
    }
}
