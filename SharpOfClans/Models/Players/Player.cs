using System.Collections.Generic;
using Newtonsoft.Json;
using SharpOfClans.Models.Labels;
using SharpOfClans.Models.Leagues;
using SharpOfClans.Models.Players.ItemLevelLists;

namespace SharpOfClans.Models.Players
{
    public class Player
    {
        /// <summary>
        /// The player's clan.
        /// </summary>
        [JsonProperty("clan")]
        public PlayerClan Clan { get; set; }

        /// <summary>
        /// The player's league.
        /// </summary>
        [JsonProperty("league")]
        public League League { get; set; }

        /// <summary>
        /// The player's role in the clan he's in.
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <summary>
        /// The player's total attack wins.
        /// </summary>
        [JsonProperty("attackWins")]
        public int AttackWins { get; set; }

        /// <summary>
        /// The player's total defense wins.
        /// </summary>
        [JsonProperty("defenseWins")]
        public int DefenseWins { get; set; }

        /// <summary>
        /// The player's townhall level.
        /// </summary>
        [JsonProperty("townHallLevel")]
        public int TownHallLevel { get; set; }

        /// <summary>
        /// The player's townhall weapon level.
        /// </summary>
        [JsonProperty("townHallWeaponLevel")]
        public int TownHallWeaponLevel { get; set; }

        /// <summary>
        /// The player's total wins in versus battles.
        /// <remarks><para>Apparently the same as <see cref="VersusBattleWinCount"/></para></remarks>
        /// </summary>
        [JsonProperty("versusBattleWins")]
        public int VersusBattleWins { get; set; }

        /// <summary>
        /// The player's statistics in the legend league.
        /// <remarks><para>Will be null if the player's isn't in the legend league.</para></remarks>
        /// </summary>
        [JsonProperty("legendStatistics")]
        public LegendStatistics LegendStatistics { get; set; }

        /// <summary>
        /// A list of the player's troops.
        /// </summary>
        [JsonProperty("troops")]
        public List<Troop> Troops { get; set; }

        /// <summary>
        /// A list of the player's heroes.
        /// </summary>
        [JsonProperty("heroes")]
        public List<Hero> Heroes { get; set; }

        /// <summary>
        /// A list of the player's spells.
        /// </summary>
        [JsonProperty("spells")]
        public List<Spell> Spells { get; set; }

        /// <summary>
        /// A list of the player's labels.
        /// </summary>
        [JsonProperty("labels")]
        public List<Label> Labels { get; set; }

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
        /// The player's level.
        /// </summary>
        [JsonProperty("expLevel")]
        public int ExpLevel { get; set; }

        /// <summary>
        /// The player's current trophies.
        /// </summary>
        [JsonProperty("trophies")]
        public int Trophies { get; set; }

        /// <summary>
        /// The player's best trophies.
        /// </summary>
        [JsonProperty("bestTrophies")]
        public int BestTrophies { get; set; }

        /// <summary>
        /// The player's total donations.
        /// </summary>
        [JsonProperty("donations")]
        public int Donations { get; set; }

        /// <summary>
        /// The player's total donations received.
        /// </summary>
        [JsonProperty("donationsReceived")]
        public int DonationsReceived { get; set; }

        /// <summary>
        /// The player's builder hall level.
        /// </summary>
        [JsonProperty("builderHallLevel")]
        public int BuilderHallLevel { get; set; }

        /// <summary>
        /// The player's current trophies in versus battles. 
        /// </summary>
        [JsonProperty("versusTrophies")]
        public int VersusTrophies { get; set; }

        /// <summary>
        /// The player's best trophies in versus battles.
        /// </summary>
        [JsonProperty("bestVersusTrophies")]
        public int BestVersusTrophies { get; set; }

        /// <summary>
        /// The player's total war stars.
        /// </summary>
        [JsonProperty("warStars")]
        public int WarStars { get; set; }

        /// <summary>
        /// A list of the player's achievements.
        /// </summary>
        [JsonProperty("achievements")]
        public List<PlayerAchievementProgress> Achievements { get; set; }

        /// <summary>
        /// The player's total wins in versus battles.
        /// <remarks><para>Apparently the same as <see cref="VersusBattleWins"/>.</para></remarks>
        /// </summary>
        [JsonProperty("versusBattleWinCount")]
        public int VersusBattleWinCount { get; set; }
    }
}
