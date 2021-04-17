using Newtonsoft.Json;

namespace SharpOfClans.Models.Clans.War
{
    public class WarLeague
    {
        /// <summary>
        /// The war league's id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The war league's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
