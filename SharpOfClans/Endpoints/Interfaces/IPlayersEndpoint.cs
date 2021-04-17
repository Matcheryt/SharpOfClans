using System.Threading.Tasks;
using SharpOfClans.Models.Players;

namespace SharpOfClans.Endpoints.Interfaces
{
    /// <summary>
    /// Players Endpoint.
    /// </summary>
    public interface IPlayersEndpoint
    {
        /// <summary>
        /// Retrieve player by tag.
        /// </summary>
        /// <param name="tag">The player tag of the player you want to search.</param>
        /// <returns>A player.</returns>
        Task<Player> GetPlayerAsync(string tag);

        /// <summary>
        /// Verify player token.
        /// </summary>
        /// <param name="tag">The player tag of the player you want to search.</param>
        /// <param name="token">The player token you want to verify.</param>
        /// <returns>A player token response.</returns>
        Task<PlayerToken> VerifyPlayerTokenAsync(string tag, string token);
    }
}
