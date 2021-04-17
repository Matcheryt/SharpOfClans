using System.Threading.Tasks;
using SharpOfClans.Endpoints.Interfaces;
using SharpOfClans.Http.Interfaces;
using SharpOfClans.Models.Goldpass;

namespace SharpOfClans.Endpoints
{
    /// <summary>
    /// Implementation of <see cref="IGoldpassEndpoint"/>.
    /// </summary>
    internal class GoldpassEndpoint : IGoldpassEndpoint
    {
        private const string GoldpassUrl = "/goldpass/seasons/current";

        private readonly IRequester _requester;

        /// <summary>
        /// Creates a new instance of the <see cref="GoldpassEndpoint"/> class.
        /// </summary>
        /// <param name="requester">The <see cref="IRequester"/> to use.</param>
        public GoldpassEndpoint(IRequester requester)
        {
            _requester = requester;
        }

        /// <inheritdoc />
        public async Task<GoldpassSeason> GetCurrentGoldpassSeasonAsync()
            => await _requester.GetAndDeserializeAsync<GoldpassSeason>(GoldpassUrl);
    }
}
