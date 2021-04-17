using Newtonsoft.Json;

namespace SharpOfClans.Models.Locations
{
    public class Location
    {
        /// <summary>
        /// The location's id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The location's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns <see langword="true"></see> if the location is a country.
        /// </summary>
        [JsonProperty("isCountry")]
        public bool IsCountry { get; set; }

        /// <summary>
        /// The location's country code as per the <em>ISO 3166-1 alfa-2</em> standard.
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }
}
