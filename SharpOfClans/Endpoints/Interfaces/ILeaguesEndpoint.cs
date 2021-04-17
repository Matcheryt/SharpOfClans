using System.Threading.Tasks;
using SharpOfClans.Models.Clans.War;
using SharpOfClans.Models.Common;
using SharpOfClans.Models.Leagues;
using SharpOfClans.Models.Leagues.Enums;
using SharpOfClans.Models.Rankings;
using SharpOfClans.Paging;

namespace SharpOfClans.Endpoints.Interfaces
{
    /// <summary>
    /// LeagueNames Endpoint.
    /// </summary>
    public interface ILeaguesEndpoint
    {
        /// <summary>
        /// Retrieves leagues list.
        /// </summary>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="League"/>.</returns>
        Task<ItemsList<League>> GetLeaguesAsync();

        /// <summary>
        /// Retrieves specified league season rankings.
        /// </summary>
        /// <remarks>
        /// League season information is available only for Legend League.
        /// <br/>
        /// It's recommended to specify a paging filter with a limit as the call can take several seconds if no limit is applied.
        /// </remarks>
        /// <param name="league">The league.</param>
        /// <param name="seasonId">The season id.</param>
        /// <param name="pagingFilter">The paging filter for the search.</param>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="PlayerRanking"/>.</returns>
        Task<ItemsList<PlayerRanking>> GetLeagueSeasonRankingsAsync(Leagues league, string seasonId, PagingFilter pagingFilter = null);

        /// <summary>
        /// Retrieve league information.
        /// </summary>
        /// <param name="league">The league.</param>
        /// <returns>A <see cref="League"/>.</returns>
        Task<League> GetLeagueInfoAsync(Leagues league);

        /// <summary>
        /// Retrieve league seasons.
        /// </summary>
        /// <remarks>
        /// League season information is available only for Legend League.
        /// </remarks>
        /// <param name="league">The league.</param>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="LeagueSeason"/>.</returns>
        Task<ItemsList<LeagueSeason>> GetLeagueSeasonsAsync(Leagues league);

        /// <summary>
        /// Retrieve war league information.
        /// </summary>
        /// <param name="league">The league.</param>
        /// <returns>A <see cref="WarLeague"/>.</returns>
        Task<WarLeague> GetWarLeagueAsync(WarLeagues league);

        /// <summary>
        /// Retrieve war leagues list.
        /// </summary>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="WarLeague"/>.</returns>
        Task<ItemsList<WarLeague>> GetWarLeaguesAsync();
    }
}
