using System.Threading.Tasks;
using SharpOfClans.Models.Common;
using SharpOfClans.Models.Labels;

namespace SharpOfClans.Endpoints.Interfaces
{
    /// <summary>
    /// Labels Endpoint.
    /// </summary>
    public interface ILabelsEndpoint
    {
        /// <summary>
        /// Retrieves a list of player labels.
        /// </summary>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="Label"/>.</returns>
        Task<ItemsList<Label>> GetPlayerLabelsAsync();

        /// <summary>
        /// Retrieves a list of clan labels.
        /// </summary>
        /// <returns>An <see cref="ItemsList{T}"/> whose generic type argument is <see cref="Label"/>.</returns>
        Task<ItemsList<Label>> GetClanLabelsAsync();
    }
}
