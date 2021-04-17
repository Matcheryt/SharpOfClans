using Newtonsoft.Json;
using SharpOfClans.Models.Common;

namespace SharpOfClans.Models.Players
{
    public class PlayerClan
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
        /// The clan's level.
        /// </summary>
        [JsonProperty("clanLevel")]
        public int ClanLevel { get; set; }

        /// <summary>
        /// The clan's badge urls.
        /// </summary>
        [JsonProperty("badgeUrls")]
        public BadgeUrls BadgeUrls { get; set; }
    }
}
