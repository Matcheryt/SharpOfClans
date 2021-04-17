using Newtonsoft.Json;

namespace SharpOfClans.Models.Players.ItemLevelLists
{
    public class Troop : PlayerItemLevelList
    {
        /// <summary>
        /// Whether the super troop is active or not.
        /// </summary>
        [JsonProperty("superTroopIsActive")]
        public bool SuperTroopIsActive { get; set; }
    }
}
