using System;
using Newtonsoft.Json;
using SharpOfClans.Converters;

namespace SharpOfClans.Models.Clans.War
{
    public class PastWar
    {
        /// <summary>
        /// The result of the war.
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// The time at which the war ended.
        /// </summary>
        [JsonProperty("endTime"), JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// The amount of players on each side.
        /// </summary>
        [JsonProperty("teamSize")]
        public int TeamSize { get; set; }

        /// <summary>
        /// The clan you searched for.
        /// </summary>
        [JsonProperty("clan")]
        public WarClan Clan { get; set; }

        /// <summary>
        /// The opponent clan of the clan you searched for.
        /// </summary>
        [JsonProperty("opponent")]
        public WarClan Opponent { get; set; }
    }
}
