using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpOfClans.Models.Clans.WarLeague.LeagueWar
{
    public class CwlWarMember
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
        [JsonProperty("townhallLevel")]
        public int TownhallLevel { get; set; }

        /// <summary>
        /// The player's position in map.
        /// </summary>
        [JsonProperty("mapPosition")]
        public int MapPosition { get; set; }

        /// <summary>
        /// The player's total times attacked by the opponents.
        /// </summary>
        [JsonProperty("opponentAttacks")]
        public int OpponentAttacks { get; set; }

        /// <summary>
        /// The list of the player's attacks.
        /// </summary>
        [JsonProperty("attacks")]
        public List<CwlAttack> Attacks { get; set; }

        /// <summary>
        /// The best opponent attack.
        /// </summary>
        [JsonProperty("bestOpponentAttack")]
        public CwlAttack BestOpponentAttack { get; set; }
    }
}
