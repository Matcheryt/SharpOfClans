using System.Threading.Tasks;
using System.Web;
using SharpOfClans.Endpoints.Interfaces;
using SharpOfClans.Http.Interfaces;
using SharpOfClans.Models.Players;

namespace SharpOfClans.Endpoints
{
    /// <summary>
    /// Implementation of <see cref="IPlayersEndpoint"/>.
    /// </summary>
    internal class PlayersEndpoint : IPlayersEndpoint
    {
        private const string PlayerInfoUrl = "/players/";

        private readonly IRequester _requester;

        /// <summary>
        /// Creates a new instance of the <see cref="PlayersEndpoint"/> class.
        /// </summary>
        /// <param name="requester">The <see cref="IRequester"/> to use.</param>
        public PlayersEndpoint(IRequester requester)
        {
            _requester = requester;
        }

        /// <inheritdoc />
        public async Task<Player> GetPlayerAsync(string tag)
            => await _requester.GetAndDeserializeAsync<Player>(PlayerInfoUrl + HttpUtility.UrlEncode(tag));

        /// <inheritdoc />
        public async Task<PlayerToken> VerifyPlayerTokenAsync(string tag, string token)
            => await _requester.PostAndDeserializeAsync<PlayerToken>(
                PlayerInfoUrl + HttpUtility.UrlEncode(tag) + "/verifytoken", requestBody: $"{{ \"token\": \"{token}\" }}");
    }
}