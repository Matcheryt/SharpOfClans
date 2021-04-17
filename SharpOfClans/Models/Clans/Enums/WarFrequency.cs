using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpOfClans.Models.Clans.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WarFrequency
    {
        /// <summary>
        /// The clan's war frequency is unknown.
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 0,

        /// <summary>
        /// The clan's war frequency is never.
        /// </summary>
        [EnumMember(Value = "never")]
        Never,

        /// <summary>
        /// The clan's war frequency is less than once per week.
        /// </summary>
        [EnumMember(Value = "lessThanOncePerWeek")]
        LessThanOncePerWeek,

        /// <summary>
        /// The clan's war frequency is once per week.
        /// </summary>
        [EnumMember(Value = "oncePerWeek")]
        OncePerWeek,

        /// <summary>
        /// The clan's war frequency is more than once per week.
        /// </summary>
        [EnumMember(Value = "moreThanOncePerWeek")]
        MoreThanOncePerWeek,

        /// <summary>
        /// The clan's war frequency is always.
        /// </summary>
        [EnumMember(Value = "always")]
        Always
    }
}