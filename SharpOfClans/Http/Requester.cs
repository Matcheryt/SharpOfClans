using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using SharpOfClans.Http.Interfaces;

namespace SharpOfClans.Http
{
    /// <summary>
    /// Implementation of <see cref="IRequester"/>.
    /// </summary>
    internal class Requester : RequesterBase, IRequester
    {
        /// <summary>
        /// Creates a new <see cref="Requester"/>.
        /// </summary>
        /// <param name="token">The Clash of Clans API token.</param>
        public Requester(string token) : base(token) { }


        /// <inheritdoc />
        public async Task<T> GetAndDeserializeAsync<T>(string url, Dictionary<string, object> queryParams = null)
        {
            var request = CreateRequest(url, Method.GET, queryParams);

            var response = await ExecuteRequestAsync(request);

            return JsonConvert.DeserializeObject<T>(response.Content);
        }


        /// <inheritdoc />
        public async Task<T> PostAndDeserializeAsync<T>(string url, Dictionary<string, object> queryParams = null, string requestBody = null)
        {
            var request = CreateRequest(url, Method.POST, queryParams, requestBody);

            var response = await ExecuteRequestAsync(request);

            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}