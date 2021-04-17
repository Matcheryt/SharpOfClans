using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpOfClans.Models.Clans.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WarState
    {
        /// <summary>
        /// The clan doesn't have an active war.
        /// </summary>
        [EnumMember(Value = "notInWar")]
        NotInWar = 1,

        /// <summary>
        /// The war is in the preparation day.
        /// </summary>
        [EnumMember(Value = "preparation")]
        Preparation = 2,

        /// <summary>
        /// The war is in the battle day.
        /// </summary>
        [EnumMember(Value = "inWar")]
        InWar = 3,

        /// <summary>
        /// The war has ended.
        /// </summary>
        [EnumMember(Value = "warEnded")]
        WarEnded = 4
    }
}
