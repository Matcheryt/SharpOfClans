using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using SharpOfClans.Models.Common;

namespace SharpOfClans.Http
{
    internal abstract class RequesterBase
    {
        private static readonly HashSet<HttpStatusCode> ClashApiStatusCodes = new()
        {
            HttpStatusCode.BadRequest,
            HttpStatusCode.Forbidden,
            HttpStatusCode.NotFound,
            HttpStatusCode.TooManyRequests,
            HttpStatusCode.InternalServerError,
            HttpStatusCode.ServiceUnavailable
        };

        private readonly RestClient _restClient;

        /// <summary>
        /// Creates a new instance of <see cref="RequesterBase" />.
        /// </summary>
        /// <param name="token">Your Clash of Clans development token.</param>
        /// <exception cref="ArgumentNullException"></exception>
        protected RequesterBase(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new ArgumentNullException(nameof(token));

            _restClient = new RestClient("https://api.clashofclans.com/v1");
            _restClient.AddDefaultHeader("Authorization", $"Bearer {token}");
            _restClient.UseNewtonsoftJson();
        }


        /// <summary>
        /// Creates and executes a request with specified options.
        /// </summary>
        /// <param name="relativeUrl">The relative url to send the request.</param>
        /// <param name="httpMethod">The <see cref="Method" /> for the request.</param>
        /// <param name="queryParams">A list with parameters to include in the query.</param>
        /// <param name="requestBody">The body to send with the request.</param>
        /// <returns>A string with the response content.</returns>
        protected static RestRequest CreateRequest(string relativeUrl, Method httpMethod,
            Dictionary<string, object> queryParams = null, string requestBody = null)
        {
            //Create the request
            var request = new RestRequest(relativeUrl, httpMethod);

            //If there are any query parameters, include them to the request
            if (queryParams != null)
            {
                foreach (var (name, value) in queryParams)
                {
                    request.AddQueryParameter(name, value.ToString()?.ToLower() ?? string.Empty, true);
                }
            }

            //Add request body if not empty
            if (!string.IsNullOrEmpty(requestBody))
                request.AddParameter("application/json; charset=utf-8", requestBody, ParameterType.RequestBody);

            return request;
        }


        /// <summary>
        /// Executes the specified request.
        /// </summary>
        /// <param name="request">The request to execute.</param>
        /// <returns>The request response as <see cref="IRestResponse" />.</returns>
        protected async Task<IRestResponse> ExecuteRequestAsync(RestRequest request)
        {
            //Executes the request
            var response = await _restClient.ExecuteAsync(request);

            //If there's any error with the request, let the following function handle the failure
            if (!response.IsSuccessful)
            {
                HandleFailedRequest(response);
            }

            return response;
        }


        /// <summary>
        /// Handles the error from a response.
        /// </summary>
        /// <param name="response">The received response.</param>
        private static void HandleFailedRequest(IRestResponse response)
        {
            if (!ClashApiStatusCodes.Contains(response.StatusCode))
                throw new ClashApiException("Unhandled exception", response.StatusCode);

            string exceptionMessage;

            try
            {
                var failedRequest = JsonConvert.DeserializeObject<FailedRequest>(response.Content);

                exceptionMessage = FormatExceptionMessage(failedRequest);
            }
            catch
            {
                exceptionMessage = response.StatusCode.ToString();
            }

            throw new ClashApiException(exceptionMessage, response.StatusCode);
        }


        /// <summary>
        /// Formats the exception message.
        /// </summary>
        /// <param name="failedRequest">The failed request.</param>
        /// <returns>The formatted exception message.</returns>
        private static string FormatExceptionMessage(FailedRequest failedRequest)
        {
            var reason = failedRequest?.Reason;
            var message = failedRequest?.Message;
            var type = failedRequest?.Type;

            if (failedRequest?.Reason != null)
            {
                reason = Regex.Replace(failedRequest.Reason, "([a-z])([A-Z])", "$1 $2");
                reason = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(reason);
            }

            var exceptionMessage = string.IsNullOrEmpty(message) ? reason : $"{reason} - {message} {type}";

            return exceptionMessage;
        }
    }
}