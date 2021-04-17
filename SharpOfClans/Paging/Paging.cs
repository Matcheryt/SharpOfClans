using Newtonsoft.Json;

namespace SharpOfClans.Paging
{
    /// <summary>
    /// Class containing pagination info returned by Clash of Clans API.
    /// </summary>
    public class Paging
    {
        /// <summary>
        /// Cursors indicating which page you're on this specific request.
        /// </summary>
        [JsonProperty("cursors")]
        public Cursors Cursors { get; set; }
    }

    public class Cursors
    {
        /// <summary>
        /// Marker representing the next page.
        /// </summary>
        [JsonProperty("after")]
        public string After { get; set; }

        /// <summary>
        /// Marker representing the previous page.
        /// </summary>
        [JsonProperty("before")]
        public string Before { get; set; }
    }
}
