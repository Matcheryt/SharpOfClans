using System.Threading.Tasks;
using SharpOfClans.Endpoints.Interfaces;
using SharpOfClans.Http.Interfaces;
using SharpOfClans.Models.Common;
using SharpOfClans.Models.Locations;
using SharpOfClans.Models.Rankings;

namespace SharpOfClans.Endpoints
{
    /// <summary>
    /// Implementation of <see cref="ILocationsEndpoint"/>.
    /// </summary>
    internal class LocationsEndpoint : ILocationsEndpoint
    {
        private const string LocationsUrl = "/locations/";

        private readonly IRequester _requester;

        /// <summary>
        /// Creates a new instance of the <see cref="LocationsEndpoint"/> class.
        /// </summary>
        /// <param name="requester">The <see cref="IRequester"/> to use.</param>
        public LocationsEndpoint(IRequester requester)
        {
            _requester = requester;
        }

        /// <inheritdoc />
        public async Task<ItemsList<ClanRanking>> GetLocationClanRankingsAsync(int locationId)
            => await _requester.GetAndDeserializeAsync<ItemsList<ClanRanking>>(LocationsUrl + locationId + "/rankings/clans");

        /// <inheritdoc />
        public async Task<ItemsList<PlayerRanking>> GetLocationPlayerRankingsAsync(int locationId)
            => await _requester.GetAndDeserializeAsync<ItemsList<PlayerRanking>>(LocationsUrl + locationId + "/rankings/players");

        /// <inheritdoc />
        public async Task<ItemsList<ClanVersusRanking>> GetLocationClansVersusRankingsAsync(int locationId)
            => await _requester.GetAndDeserializeAsync<ItemsList<ClanVersusRanking>>(LocationsUrl + locationId + "/rankings/clans-versus");

        /// <inheritdoc />
        public async Task<ItemsList<PlayerVersusRanking>> GetLocationPlayersVersusRankingsAsync(int locationId)
            => await _requester.GetAndDeserializeAsync<ItemsList<PlayerVersusRanking>>(LocationsUrl + locationId + "/rankings/players-versus");

        /// <inheritdoc />
        public async Task<ItemsList<Location>> GetLocationsListAsync()
            => await _requester.GetAndDeserializeAsync<ItemsList<Location>>(LocationsUrl);

        /// <inheritdoc />
        public async Task<Location> GetLocationInfoAsync(int locationId)
            => await _requester.GetAndDeserializeAsync<Location>(LocationsUrl + locationId);
    }
}
