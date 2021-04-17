using System.Threading.Tasks;
using SharpOfClans.Endpoints.Interfaces;
using SharpOfClans.Http.Interfaces;
using SharpOfClans.Models.Common;
using SharpOfClans.Models.Labels;

namespace SharpOfClans.Endpoints
{
    /// <summary>
    /// Implementation of <see cref="ILabelsEndpoint"/>.
    /// </summary>
    internal class LabelsEndpoint : ILabelsEndpoint
    {
        private const string PlayerLabelsUrl = "/labels/players";
        private const string ClanLabelsUrl = "/labels/clans";

        private readonly IRequester _requester;

        /// <summary>
        /// Creates a new instance of the <see cref="LabelsEndpoint"/> class.
        /// </summary>
        /// <param name="requester">The <see cref="IRequester"/> to use.</param>
        public LabelsEndpoint(IRequester requester)
        {
            _requester = requester;
        }

        /// <inheritdoc />
        public async Task<ItemsList<Label>> GetPlayerLabelsAsync()
            => await _requester.GetAndDeserializeAsync<ItemsList<Label>>(PlayerLabelsUrl);

        /// <inheritdoc />
        public async Task<ItemsList<Label>> GetClanLabelsAsync()
            => await _requester.GetAndDeserializeAsync<ItemsList<Label>>(ClanLabelsUrl);
    }
}
