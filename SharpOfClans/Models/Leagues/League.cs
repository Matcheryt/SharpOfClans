using Newtonsoft.Json;
using SharpOfClans.Models.Common;

namespace SharpOfClans.Models.Leagues
{
    public class League
    {
        /// <summary>
        /// The league's id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The league's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The league's icon urls.
        /// </summary>
        [JsonProperty("iconUrls")]
        public IconUrls IconUrls { get; set; }
    }
}
