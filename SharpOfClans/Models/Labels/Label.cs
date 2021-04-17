using Newtonsoft.Json;
using SharpOfClans.Models.Common;

namespace SharpOfClans.Models.Labels
{
    public class Label
    {
        /// <summary>
        /// The label's id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The label's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The label's icon's urls.
        /// </summary>
        [JsonProperty("iconUrls")]
        public IconUrls IconUrls { get; set; }
    }
}
