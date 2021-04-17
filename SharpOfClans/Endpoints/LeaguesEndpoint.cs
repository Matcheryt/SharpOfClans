using System.Threading.Tasks;
using SharpOfClans.Endpoints.Interfaces;
using SharpOfClans.Http.Interfaces;
using SharpOfClans.Models.Clans.War;
using SharpOfClans.Models.Common;
using SharpOfClans.Models.Leagues;
using SharpOfClans.Models.Leagues.Enums;
using SharpOfClans.Models.Rankings;
using SharpOfClans.Paging;

namespace SharpOfClans.Endpoints
{
    internal class LeaguesEndpoint : ILeaguesEndpoint
    {
        private const string LeaguesUrl = "/leagues/";
        private const string WarLeaguesUrl = "/warleagues/";

        private readonly IRequester _requester;

        /// <summary>
        /// Creates a new instance of the <see cref="LeaguesEndpoint"/> class.
        /// </summary>
        /// <param name="requester">The <see cref="IRequester"/> to use.</param>
        public LeaguesEndpoint(IRequester requester)
        {
            _requester = requester;
        }

        /// <inheritdoc />
        public async Task<ItemsList<League>> GetLeaguesAsync()
            => await _requester.GetAndDeserializeAsync<ItemsList<League>>(LeaguesUrl);


        /// <inheritdoc />
        public async Task<ItemsList<PlayerRanking>> GetLeagueSeasonRankingsAsync(Leagues league, string seasonId, 
            PagingFilter pagingFilter = null)
            => await _requester.GetAndDeserializeAsync<ItemsList<PlayerRanking>>(LeaguesUrl + (int)league + "/seasons/" 
                + seasonId, pagingFilter?.ToDictionary());


        /// <inheritdoc />
        public async Task<League> GetLeagueInfoAsync(Leagues league)
            => await _requester.GetAndDeserializeAsync<League>(LeaguesUrl + (int)league);


        /// <inheritdoc />
        public async Task<ItemsList<LeagueSeason>> GetLeagueSeasonsAsync(Leagues league)
            => await _requester.GetAndDeserializeAsync<ItemsList<LeagueSeason>>(LeaguesUrl + (int)league + "/seasons");


        /// <inheritdoc />
        public async Task<WarLeague> GetWarLeagueAsync(WarLeagues warLeague)
            => await _requester.GetAndDeserializeAsync<WarLeague>(WarLeaguesUrl + (int)warLeague);


        /// <inheritdoc />
        public async Task<ItemsList<WarLeague>> GetWarLeaguesAsync()
            => await _requester.GetAndDeserializeAsync<ItemsList<WarLeague>>(WarLeaguesUrl);
    }
}
