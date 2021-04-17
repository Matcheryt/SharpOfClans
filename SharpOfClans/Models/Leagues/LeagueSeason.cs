using Newtonsoft.Json;

namespace SharpOfClans.Models.Leagues
{
    public class LeagueSeason
    {
        /// <summary>
        /// The league season id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
