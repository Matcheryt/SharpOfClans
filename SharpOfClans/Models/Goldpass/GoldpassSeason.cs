using System;
using Newtonsoft.Json;
using SharpOfClans.Converters;

namespace SharpOfClans.Models.Goldpass
{
    public class GoldpassSeason
    {
        /// <summary>
        /// Season start time.
        /// </summary>
        [JsonProperty("startTime"), JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Season end time.
        /// </summary>
        [JsonProperty("endTime"), JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime EndTime { get; set; }
    }
}
