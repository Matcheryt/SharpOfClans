using System.Collections.Generic;
using Newtonsoft.Json;
using SharpOfClans.Models.Clans.Enums;
using SharpOfClans.Models.Common;
using SharpOfClans.Models.Labels;
using SharpOfClans.Models.Locations;

namespace SharpOfClans.Models.Clans
{
    public class Clan
    {
        /// <summary>
        /// The clan's tag.
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// The clan's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The clan's type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The clan's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The clan's location.
        /// </summary>
        [JsonProperty("location")]
        public Location Location { get; set; }

        /// <summary>
        /// The clan's badge urls.
        /// </summary>
        [JsonProperty("badgeUrls")]
        public BadgeUrls BadgeUrls { get; set; }

        /// <summary>
        /// The clan's level.
        /// </summary>
        [JsonProperty("clanLevel")]
        public int ClanLevel { get; set; }

        /// <summary>
        /// The clan's points.
        /// </summary>
        [JsonProperty("clanPoints")]
        public int ClanPoints { get; set; }

        /// <summary>
        /// The clan's versus points.
        /// </summary>
        [JsonProperty("clanVersusPoints")]
        public int ClanVersusPoints { get; set; }

        /// <summary>
        /// The clan's required trophies.
        /// </summary>
        [JsonProperty("requiredTrophies")]
        public int RequiredTrophies { get; set; }

        /// <summary>
        /// The clan's war frequency.
        /// </summary>
        [JsonProperty("warFrequency")]
        public WarFrequency WarFrequency { get; set; }

        /// <summary>
        /// The clan's war win streak.
        /// </summary>
        [JsonProperty("warWinStreak")]
        public int WarWinStreak { get; set; }

        /// <summary>
        /// The clan's total wins in clan wars.
        /// </summary>
        [JsonProperty("warWins")]
        public int WarWins { get; set; }

        /// <summary>
        /// The clan's total ties in clan wars.
        /// </summary>
        [JsonProperty("warTies")]
        public int WarTies { get; set; }

        /// <summary>
        /// The clan's total losses in clan wars.
        /// </summary>
        [JsonProperty("warLosses")]
        public int WarLosses { get; set; }

        /// <summary>
        /// The clan's war log privacy state.
        /// </summary>
        [JsonProperty("isWarLogPublic")]
        public bool IsWarLogPublic { get; set; }

        /// <summary>
        /// The clan's war league.
        /// </summary>
        [JsonProperty("warLeague")]
        public War.WarLeague WarLeague { get; set; }

        /// <summary>
        /// The clan's total members.
        /// </summary>
        [JsonProperty("members")]
        public int Members { get; set; }

        /// <summary>
        /// The clan's member list.
        /// </summary>
        [JsonProperty("memberList")]
        public List<Member> MemberList { get; set; }

        /// <summary>
        /// The clan's labels.
        /// </summary>
        [JsonProperty("labels")]
        public List<Label> Labels { get; set; }
    }
}