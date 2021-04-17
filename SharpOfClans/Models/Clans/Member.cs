using Newtonsoft.Json;
using SharpOfClans.Models.Leagues;

namespace SharpOfClans.Models.Clans
{
    public class Member
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
        /// The player's role in the clan.
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <summary>
        /// The player's experience level.
        /// </summary>
        [JsonProperty("expLevel")]
        public int ExpLevel { get; set; }

        /// <summary>
        /// The player's league.
        /// </summary>
        [JsonProperty("league")]
        public League League { get; set; }

        /// <summary>
        /// The player's trophies.
        /// </summary>
        [JsonProperty("trophies")]
        public int Trophies { get; set; }

        /// <summary>
        /// The player's trophies in versus battles.
        /// </summary>
        [JsonProperty("versusTrophies")]
        public int VersusTrophies { get; set; }

        /// <summary>
        /// The player's clan ranking.
        /// </summary>
        [JsonProperty("clanRank")]
        public int ClanRank { get; set; }

        /// <summary>
        /// The player's previous clan ranking.
        /// </summary>
        [JsonProperty("previousClanRank")]
        public int PreviousClanRank { get; set; }

        /// <summary>
        /// The player's donations.
        /// </summary>
        [JsonProperty("donations")]
        public int Donations { get; set; }

        /// <summary>
        /// The player's received donations.
        /// </summary>
        [JsonProperty("donationsReceived")]
        public int DonationsReceived { get; set; }
    }
}
