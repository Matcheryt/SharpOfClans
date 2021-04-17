using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpOfClans.Models.Common
{
    public class ItemsList<T>
    {
        /// <summary>
        /// A list of <typeparamref name="T"/>.
        /// </summary>
        [JsonProperty("items")]
        public List<T> Items { get; set; }

        /// <summary>
        /// Paging returned by the API in order to navigate through long responses.
        /// </summary>
        [JsonProperty("paging")]
        public Paging.Paging Paging { get; set; }
    }
}
