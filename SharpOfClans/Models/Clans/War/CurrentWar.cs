using System;
using Newtonsoft.Json;
using SharpOfClans.Converters;
using SharpOfClans.Models.Clans.Enums;

namespace SharpOfClans.Models.Clans.War
{
    public class CurrentWar
    {
        /// <summary>
        /// The war's current state.
        /// </summary>
        [JsonProperty("state")]
        public WarState State { get; set; }

        /// <summary>
        /// The amount of players on each side.
        /// </summary>
        [JsonProperty("teamSize")]
        public int TeamSize { get; set; }

        /// <summary>
        /// The time at which the preparation starts.
        /// </summary>
        [JsonProperty("preparationStartTime"), JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime PreparationStartTime { get; set; }

        /// <summary>
        /// The time at which the war starts.
        /// </summary>
        [JsonProperty("startTime"), JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime WarStartTime { get; set; }

        /// <summary>
        /// The time at which the war ends.
        /// </summary>
        [JsonProperty("endTime"), JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime WarEndTime { get; set; }

        /// <summary>
        /// The clan you searched for.
        /// </summary>
        [JsonProperty("clan")]
        public WarClan FriendlyClan { get; set; }

        /// <summary>
        /// The opponent clan of the clan you searched for.
        /// </summary>
        [JsonProperty("opponent")]
        public WarClan OpponentClan { get; set; }
    }
}
