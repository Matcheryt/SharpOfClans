using Newtonsoft.Json;

namespace SharpOfClans.Models.Common
{
    public class BadgeUrls
    {
        /// <summary>
        /// The url to the badge's 70x70 size.
        /// </summary>
        [JsonProperty("small")]
        public string Small { get; set; }

        /// <summary>
        /// The url to the badge's 200x200 size.
        /// </summary>
        [JsonProperty("medium")]
        public string Medium { get; set; }

        /// <summary>
        /// The url to the badge's 512x512 size.
        /// </summary>
        [JsonProperty("large")]
        public string Large { get; set; }
    }
}
