using Newtonsoft.Json;
using SharpOfClans.Models.Common;

namespace SharpOfClans.Models.Rankings
{
    public class PlayerRankingClan
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
        /// The clan's badges urls.
        /// </summary>
        [JsonProperty("badgeUrls")]
        public BadgeUrls BadgeUrls { get; set; }
    }
}
