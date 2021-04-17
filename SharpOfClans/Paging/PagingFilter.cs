#nullable enable
using System.Collections.Generic;

namespace SharpOfClans.Paging
{
    /// <summary>
    /// Used to navigate through CoC's API responses that contain paging.
    /// </summary>
    public class PagingFilter
    {
        /// <summary>
        /// Limit the number of items returned in the response.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Return only items that occur after this marker.
        /// Before marker can be found from the response, inside the 'paging' property.
        /// </summary>
        /// <remarks> Note that only after or before can be specified for a request, not both. </remarks>
        public string? After { get; set; }

        /// <summary>
        /// Return only items that occur before this marker.
        /// Before marker can be found from the response, inside the 'paging' property.
        /// </summary>
        /// <remarks> Note that only after or before can be specified for a request, not both. </remarks>
        public string? Before { get; set; }



        /// <summary>
        /// Creates a dictionary according to the values in the class' properties.
        /// </summary>
        /// <returns>A dictionary where the key and value are the property name and it's value respectively.</returns>
        public Dictionary<string, object> ToDictionary()
        {
            var pagingDict = new Dictionary<string, object>();

            if (Limit != null)
                pagingDict.Add("limit", Limit);

            if (After != null)
                pagingDict.Add("after", After);

            if (Before != null)
                pagingDict.Add("before", Before);

            return pagingDict;
        }
    }
}
