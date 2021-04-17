using System.Collections.Generic;
using Newtonsoft.Json;
using SharpOfClans.Models.Common;

namespace SharpOfClans.Models.Clans.War
{
    public class WarClan
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
        /// The clan's badge urls.
        /// </summary>
        [JsonProperty("badgeUrls")]
        public BadgeUrls BadgeUrls { get; set; }

        /// <summary>
        /// The clan's level.
        /// </summary>
        [JsonProperty("clanLevel")]
        public int ClanLevel { get; set; }

        /// <summary>
        /// The clan's total attacks.
        /// </summary>
        [JsonProperty("attacks")]
        public int Attacks { get; set; }

        /// <summary>
        /// The clan's stars in the war.
        /// </summary>
        [JsonProperty("stars")]
        public int Stars { get; set; }

        /// <summary>
        /// The clan's experience earned.
        /// </summary>
        [JsonProperty("expEarned")]
        public int ExpEarned { get; set; }

        /// <summary>
        /// The clan's total destruction percentage.
        /// </summary>
        [JsonProperty("destructionPercentage")]
        public float DestructionPercentage { get; set; }

        /// <summary>
        /// The clan's war members list.
        /// </summary>
        [JsonProperty("members")]
        public List<WarMember> Members { get; set; }
    }
}
