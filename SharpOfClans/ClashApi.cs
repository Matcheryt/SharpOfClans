using SharpOfClans.Endpoints;
using SharpOfClans.Endpoints.Interfaces;
using SharpOfClans.Http;
using SharpOfClans.Http.Interfaces;

namespace SharpOfClans
{
    /// <summary>
    /// Clash Of Clans API entrypoint.
    /// </summary>
    public class ClashApi
    {
        private static ClashApi _instance;

        /// <summary>
        /// Gets or creates a new instance of ClashApi.
        /// </summary>
        /// <param name="token">Your Clash of Clans development token.</param>
        /// <returns>The <see cref="ClashApi"/> instance.</returns>
        public static ClashApi GetInstance(string token)
            => _instance ??= new ClashApi(token);


        private ClashApi(string token)
        {
            IRequester requester = new Requester(token);

            Clans = new ClansEndpoint(requester);
            Players = new PlayersEndpoint(requester);
            Leagues = new LeaguesEndpoint(requester);
            Locations = new LocationsEndpoint(requester);
            Goldpass = new GoldpassEndpoint(requester);
            Labels = new LabelsEndpoint(requester);
        }


        /// <summary>
        /// Clans Endpoint.
        /// </summary>
        public IClansEndpoint Clans { get; }

        /// <summary>
        /// Players Endpoint.
        /// </summary>
        public IPlayersEndpoint Players { get; }

        /// <summary>
        /// Leagues Endpoint.
        /// </summary>
        public ILeaguesEndpoint Leagues { get; }

        /// <summary>
        /// Locations Endpoint.
        /// </summary>
        public ILocationsEndpoint Locations { get; }

        /// <summary>
        /// Goldpass Endpoint.
        /// </summary>
        public IGoldpassEndpoint Goldpass { get; }

        /// <summary>
        /// Labels Endpoint.
        /// </summary>
        public ILabelsEndpoint Labels { get; }
    }
}