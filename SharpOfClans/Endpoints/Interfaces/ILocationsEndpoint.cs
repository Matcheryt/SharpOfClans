using System.Threading.Tasks;
using SharpOfClans.Models.Common;
using SharpOfClans.Models.Locations;
using SharpOfClans.Models.Rankings;

namespace SharpOfClans.Endpoints.Interfaces
{
    /// <summary>
    /// Locations Endpoint.
    /// </summary>
    public interface ILocationsEndpoint
    {
        /// <summary>
        /// Retrieves clan rankings for a specific location.
        /// </summary>
        /// <param name="locationId">The location id.</param>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="ClanRanking"/>.</returns>
        Task<ItemsList<ClanRanking>> GetLocationClanRankingsAsync(int locationId);

        /// <summary>
        /// Retrieves player rankings for a specific location.
        /// </summary>
        /// <param name="locationId">The location id.</param>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="PlayerRanking"/>.</returns>
        Task<ItemsList<PlayerRanking>> GetLocationPlayerRankingsAsync(int locationId);

        /// <summary>
        /// Retrieves clan versus rankings for a specific location.
        /// </summary>
        /// <param name="locationId">The location id.</param>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="ClanVersusRanking"/>.</returns>
        Task<ItemsList<ClanVersusRanking>> GetLocationClansVersusRankingsAsync(int locationId);

        /// <summary>
        /// Retrieves player versus rankings for a specific location.
        /// </summary>
        /// <param name="locationId">The location id.</param>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="PlayerVersusRanking"/>.</returns>
        Task<ItemsList<PlayerVersusRanking>> GetLocationPlayersVersusRankingsAsync(int locationId);

        /// <summary>
        /// Retrieves locations list.
        /// </summary>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="Location"/>.</returns>
        Task<ItemsList<Location>> GetLocationsListAsync();

        /// <summary>
        /// Retrieves specific location information.
        /// </summary>
        /// <param name="locationId">The location id.</param>
        /// <returns>A <see cref="Location"/>.</returns>
        Task<Location> GetLocationInfoAsync(int locationId);
    }
}
