using Newtonsoft.Json;

namespace SharpOfClans.Models.Players
{
    public class PlayerAchievementProgress
    {
        /// <summary>
        /// The achievments' name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The achievments' current stars.
        /// </summary>
        [JsonProperty("stars")]
        public int Stars { get; set; }

        /// <summary>
        /// The achievments' current value.
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }

        /// <summary>
        /// The achievements' target value.
        /// </summary>
        [JsonProperty("target")]
        public int Target { get; set; }

        /// <summary>
        /// The achievements' objective.
        /// </summary>
        [JsonProperty("info")]
        public string Info { get; set; }

        /// <summary>
        /// The achievements' progress on the objective.
        /// </summary>
        [JsonProperty("completionInfo")]
        public string CompletionInfo { get; set; }

        /// <summary>
        /// The village in which the achievement applies to.
        /// </summary>
        [JsonProperty("village")]
        public string Village { get; set; }
    }
}