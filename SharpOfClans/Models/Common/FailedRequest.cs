using Newtonsoft.Json;

namespace SharpOfClans.Models.Common
{
    public class FailedRequest
    {
        /// <summary>
        /// The reason for the request failure.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The message accompanied by the failure.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// The type of the failure.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
