using Newtonsoft.Json;

namespace SharpOfClans.Models.Clans.WarLeague
{
    public class CwlMember
    {
        /// <summary>
        /// The player's tag.
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// The player's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The player's townhall level.
        /// </summary>
        [JsonProperty("townHallLevel")]
        public int TownHallLevel { get; set; }
    }
}
