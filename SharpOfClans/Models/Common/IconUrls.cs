using Newtonsoft.Json;

namespace SharpOfClans.Models.Common
{
    public class IconUrls
    {
        /// <summary>
        /// The url to the icon's 36x36 size.
        /// </summary>
        [JsonProperty("tiny")]
        public string Tiny { get; set; }

        /// <summary>
        /// The url to the icon's 72x72 size.
        /// </summary>
        [JsonProperty("small")]
        public string Small { get; set; }

        /// <summary>
        /// The url to the icon's 288x288 size.
        /// </summary>
        [JsonProperty("medium")]
        public string Medium { get; set; }
    }
}
