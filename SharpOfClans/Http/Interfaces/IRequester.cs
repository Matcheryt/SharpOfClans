using System.Collections.Generic;
using System.Threading.Tasks;

namespace SharpOfClans.Http.Interfaces
{
    /// <summary>
    /// Requester interface.
    /// </summary>
    internal interface IRequester
    {
        /// <summary>
        /// Executes a GET request to specified url.
        /// </summary>
        /// <typeparam name="T">The .NET type to deserialize the object to.</typeparam>
        /// <param name="relativeUrl">The relative url of the request.</param>
        /// <param name="queryParams">The query parameters to send with the request.</param>
        /// <returns>The deserialized object.</returns>
        Task<T> GetAndDeserializeAsync<T>(string relativeUrl, Dictionary<string, object> queryParams = null);

        /// <summary>
        /// Executes a POST request to specified url.
        /// </summary>
        /// <typeparam name="T">The .NET type to deserialize the object to.</typeparam>
        /// <param name="relativeUrl">The relative url of the request.</param>
        /// <param name="queryParams">The query parameters to send with the request.</param>
        /// <param name="requestBody">The request body to send with the request.</param>
        /// <returns>The deserialized object.</returns>
        Task<T> PostAndDeserializeAsync<T>(string relativeUrl, Dictionary<string, object> queryParams = null, string requestBody = null);
    }
}