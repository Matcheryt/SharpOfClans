using Newtonsoft.Json;

namespace SharpOfClans.Models.Clans.War
{
    public class Attack
    {
        /// <summary>
        /// The attacker's tag.
        /// </summary>
        [JsonProperty("attackerTag")]
        public string AttackerTag { get; set; }

        /// <summary>
        /// The defender's tag.
        /// </summary>
        [JsonProperty("defenderTag")]
        public string DefenderTag { get; set; }

        /// <summary>
        /// The attack's total stars.
        /// </summary>
        [JsonProperty("stars")]
        public int Stars { get; set; }

        /// <summary>
        /// The attack's village destruction percentage.
        /// </summary>
        [JsonProperty("destructionPercentage")]
        public int DestructionPercentage { get; set; }

        /// <summary>
        /// The attack's order.
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }

        /// <summary>
        /// The attack's duration.
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }
    }
}
