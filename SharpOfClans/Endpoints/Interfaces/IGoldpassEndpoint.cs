using System.Threading.Tasks;
using SharpOfClans.Models.Goldpass;

namespace SharpOfClans.Endpoints.Interfaces
{
    /// <summary>
    /// Goldpass Endpoint.
    /// </summary>
    public interface IGoldpassEndpoint
    {
        /// <summary>
        /// Retrieves current goldpass season.
        /// </summary>
        /// <returns>A <see cref="GoldpassSeason"/>.</returns>
        Task<GoldpassSeason> GetCurrentGoldpassSeasonAsync();
    }
}
