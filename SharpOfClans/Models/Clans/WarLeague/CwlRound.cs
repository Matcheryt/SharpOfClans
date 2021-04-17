using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpOfClans.Models.Clans.WarLeague
{
    public class CwlRound
    {
        /// <summary>
        /// A list of war tags for each CWL round wars.
        /// </summary>
        [JsonProperty("warTags")]
        public List<string> WarTags { get; set; }
    }
}
