#nullable enable
using System.Collections.Generic;
using SharpOfClans.Models.Clans.Enums;

namespace SharpOfClans.Endpoints.Structs
{
    /// <summary>
    /// Used to filter the results when searching for clans.
    /// </summary>
    public struct SearchFilter
    {
        /// <summary>
        /// Search clans by name.
        /// </summary>
        /// <remarks>
        /// If name is used as part of search query, it needs to be at least three characters long.
        /// Name search parameter is interpreted as wild card search, so it may appear anywhere in the clan name.
        /// </remarks>
        public string? ClanName { get; set; }

        /// <summary>
        /// Filter by clan war frequency.
        /// </summary>
        public WarFrequency? WarFrequency { get; set; }

        /// <summary>
        /// Filter by clan location identifier.
        /// </summary>
        /// <remarks>
        /// For a list of available locations, refer to <see cref="LocationsEndpoint"/>.
        /// </remarks>
        public int? LocationId { get; set; }

        /// <summary>
        /// Filter by minimum number of clan members.
        /// </summary>
        public int? MinMembers { get; set; }

        /// <summary>
        /// Filter by maximum number of clan members.
        /// </summary>
        public int? MaxMembers { get; set; }

        /// <summary>
        /// Filter by minimum amount of clan points.
        /// </summary>
        public int? MinClanPoints { get; set; }

        /// <summary>
        /// Filter by minimum clan level.
        /// </summary>
        public int? MinClanLevel { get; set; }

        /// <summary>
        /// A list of label IDs to use for filtering results.
        /// </summary>
        /// <remarks>
        /// For a list of available labels, refer to <see cref="LabelsEndpoint"/>.
        /// </remarks>
        public List<string>? LabelIds { get; set; }


        /// <summary>
        /// Creates a dictionary according to the values in the struct's properties.
        /// </summary>
        /// <returns>A dictionary where the key and value are the property name and it's value respectively.</returns>
        public Dictionary<string, object> ToDictionary()
        {
            var searchDict = new Dictionary<string, object>();

            if (ClanName != null)
                searchDict.Add("name", ClanName);

            if (WarFrequency != null)
                searchDict.Add("warFrequency", WarFrequency);

            if (LocationId != null)
                searchDict.Add("locationId", LocationId);

            if (MinMembers != null)
                searchDict.Add("minMembers", MinMembers);

            if (MaxMembers != null)
                searchDict.Add("maxMembers", MaxMembers);

            if (MinClanPoints != null)
                searchDict.Add("minClanPoints", MinClanPoints);

            if (MinClanLevel != null)
                searchDict.Add("minClanLevel", MinClanLevel);

            if (LabelIds != null)
                searchDict.Add("labelIds", string.Join(",", LabelIds));

            return searchDict;
        }
    }
}