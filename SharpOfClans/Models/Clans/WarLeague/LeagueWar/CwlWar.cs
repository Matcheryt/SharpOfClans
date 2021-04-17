using System;
using Newtonsoft.Json;
using SharpOfClans.Converters;
using SharpOfClans.Models.Clans.Enums;

namespace SharpOfClans.Models.Clans.WarLeague.LeagueWar
{
    public class CwlWar
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
        /// The time at which the round preparation starts.
        /// </summary>
        [JsonProperty("preparationStartTime"), JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime PreparationStartTime { get; set; }

        /// <summary>
        /// The time at which the round starts.
        /// </summary>
        /// <remarks> The same as <see cref="WarStartTime"/></remarks>
        [JsonProperty("startTime"), JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The time at which the round ends.
        /// </summary>
        [JsonProperty("endTime"), JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// One of the war's participating clan.
        /// </summary>
        /// <remarks> The "default" clan returned by CoC API. </remarks>
        [JsonProperty("clan")]
        public CwlWarClan ClanOne { get; set; }

        /// <summary>
        /// One of the war's participating clan.
        /// </summary>
        /// <remarks> The "opponent" clan returned by CoC API. </remarks>
        [JsonProperty("opponent")]
        public CwlWarClan ClanTwo { get; set; }

        /// <summary>
        /// The time at which the war starts. 
        /// </summary>
        /// <remarks> The same as <see cref="StartTime"/></remarks>
        [JsonProperty("warStartTime"), JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime WarStartTime { get; set; }
    }
}
