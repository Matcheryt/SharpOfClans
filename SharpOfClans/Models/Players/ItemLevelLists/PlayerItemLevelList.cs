using Newtonsoft.Json;

namespace SharpOfClans.Models.Players.ItemLevelLists
{
    public abstract class PlayerItemLevelList
    {
        /// <summary>
        /// The name of the entity.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The level of the entity.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// The max level of the entity.
        /// </summary>
        [JsonProperty("maxLevel")]
        public int MaxLevel { get; set; }

        /// <summary>
        /// The village the entity is in.
        /// </summary>
        [JsonProperty("village")]
        public string Village { get; set; }
    }
}