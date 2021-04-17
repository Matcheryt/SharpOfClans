using System.Collections.Generic;
using Newtonsoft.Json;
using SharpOfClans.Models.Clans.Enums;

namespace SharpOfClans.Models.Clans.WarLeague
{
    public class CwlGroup
    {
        /// <summary>
        /// The CWL's group state.
        /// </summary>
        [JsonProperty("state")]
        public GroupState State { get; set; }

        /// <summary>
        /// The CWL's group season.
        /// </summary>
        [JsonProperty("season")]
        public string Season { get; set; }

        /// <summary>
        /// The CWL's group participating clans.
        /// </summary>
        [JsonProperty("clans")]
        public List<CwlClan> Clans { get; set; }

        /// <summary>
        /// The CWL's group rounds.
        /// </summary>
        [JsonProperty("rounds")]
        public List<CwlRound> Rounds { get; set; }
    }
}