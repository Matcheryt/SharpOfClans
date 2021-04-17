using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpOfClans.Models.Clans.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupState
    {
        /// <summary>
        /// The league's group is in preparation phase.
        /// </summary>
        [EnumMember(Value = "preparation")]
        Preparation = 0,

        /// <summary>
        /// The league's group is in war.
        /// </summary>
        [EnumMember(Value = "inWar")]
        InWar,

        /// <summary>
        /// The league's group has ended.
        /// </summary>
        [EnumMember(Value = "ended")]
        Ended
    }
}
