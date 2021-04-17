using Newtonsoft.Json;

namespace SharpOfClans.Models.Players
{
    public class PlayerToken
    {
        /// <summary>
        /// The player's tag.
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// The player's token.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// The token validation status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
