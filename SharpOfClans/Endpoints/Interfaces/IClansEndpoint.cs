using System.Threading.Tasks;
using SharpOfClans.Endpoints.Structs;
using SharpOfClans.Models.Clans;
using SharpOfClans.Models.Clans.War;
using SharpOfClans.Models.Clans.WarLeague;
using SharpOfClans.Models.Clans.WarLeague.LeagueWar;
using SharpOfClans.Models.Common;
using SharpOfClans.Paging;

namespace SharpOfClans.Endpoints.Interfaces
{
    /// <summary>
    /// Clans Endpoint.
    /// </summary>
    public interface IClansEndpoint
    {
        /// <summary>
        /// Retrieves clan's current clan war league group.
        /// </summary>
        /// <param name="clanTag">The clan's tag.</param>
        /// <returns></returns>
        Task<CwlGroup> GetCurrentCwlGroupAsync(string clanTag);

        /// <summary>
        /// Retrieves league war for specific clan war.
        /// </summary>
        /// <param name="warTag">The tag of the war.</param>
        /// <returns></returns>
        Task<CwlWar> GetCwlWarAsync(string warTag);

        /// <summary>
        /// Retrieves the clan's war log.
        /// </summary>
        /// <param name="clanTag">The clan's tag.</param>
        /// <param name="pagingFilter">The paging filter for the search.</param>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="PastWar"/>.</returns>
        Task<ItemsList<PastWar>> GetClanWarLogAsync(string clanTag, PagingFilter pagingFilter = null);

        /// <summary>
        /// Retrieves a list of clans according to specified search filter.
        /// </summary>
        /// <remarks>
        /// At least one filtering criteria must be defined and if name is used as part of search,
        /// it is required to be at least three characters long.
        /// </remarks>
        /// <param name="searchFilter">The search filter for the search.</param>
        /// <param name="pagingFilter">The paging filter for the search.</param>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="Clan"/>.</returns>
        Task<ItemsList<Clan>> SearchClansAsync(SearchFilter searchFilter, PagingFilter pagingFilter = null);

        /// <summary>
        /// Retrieves current clan war by clan tag.
        /// </summary>
        /// <remarks>
        /// At least one filter must be applied
        /// </remarks>
        /// <param name="clanTag">The clan's tag.</param>
        /// <returns>A <see cref="CurrentWar"/>.</returns>
        Task<CurrentWar> GetCurrentClanWarAsync(string clanTag);

        /// <summary>
        /// Retrieves clan by specified clan tag.
        /// </summary>
        /// <param name="clanTag">The clan's tag.</param>
        /// <returns>A <see cref="Clan"/>.</returns>
        Task<Clan> GetClanAsync(string clanTag);

        /// <summary>
        /// Retrieves a list of the clan's members.
        /// </summary>
        /// <param name="clanTag">The clan's tag.</param>
        /// <param name="pagingFilter">The paging filter for the search.</param>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="Member"/>.</returns>
        Task<ItemsList<Member>> GetClanMembersAsync(string clanTag, PagingFilter pagingFilter = null);
    }
}