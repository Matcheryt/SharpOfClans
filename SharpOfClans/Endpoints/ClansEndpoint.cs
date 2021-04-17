using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SharpOfClans.Endpoints.Interfaces;
using SharpOfClans.Endpoints.Structs;
using SharpOfClans.Http.Interfaces;
using SharpOfClans.Models.Clans;
using SharpOfClans.Models.Clans.War;
using SharpOfClans.Models.Clans.WarLeague;
using SharpOfClans.Models.Clans.WarLeague.LeagueWar;
using SharpOfClans.Models.Common;
using SharpOfClans.Paging;

namespace SharpOfClans.Endpoints
{
    /// <summary>
    /// Implementation of <see cref="IClansEndpoint"/>.
    /// </summary>
    internal class ClansEndpoint : IClansEndpoint
    {
        private const string ClansUrl = "/clans/";
        private const string CwlWarUrl = "/clanwarleagues/wars/";

        private readonly IRequester _requester;

        /// <summary>
        /// Creates a new instance of the <see cref="ClansEndpoint"/> class.
        /// </summary>
        /// <param name="requester">The <see cref="IRequester"/> to use.</param>
        public ClansEndpoint(IRequester requester)
        {
            _requester = requester;
        }

        /// <inheritdoc />
        public async Task<CwlGroup> GetCurrentCwlGroupAsync(string clanTag)
            => await _requester.GetAndDeserializeAsync<CwlGroup>(ClansUrl + HttpUtility.UrlEncode(clanTag) + "/currentwar/leaguegroup");

        /// <inheritdoc />
        public async Task<CwlWar> GetCwlWarAsync(string warTag)
            => await _requester.GetAndDeserializeAsync<CwlWar>(CwlWarUrl + HttpUtility.UrlEncode(warTag));

        /// <inheritdoc />
        public async Task<ItemsList<PastWar>> GetClanWarLogAsync(string clanTag, PagingFilter pagingFilter = null)
            => await _requester.GetAndDeserializeAsync<ItemsList<PastWar>>(ClansUrl + HttpUtility.UrlEncode(clanTag) + "/warlog", 
                pagingFilter?.ToDictionary());


        /// <inheritdoc />
        public async Task<ItemsList<Clan>> SearchClansAsync(SearchFilter searchFilter, PagingFilter pagingFilter = null)
        {
            Dictionary<string, object> queryParams;

            if (pagingFilter != null)
            {
                queryParams = searchFilter.ToDictionary()
                    .Union(pagingFilter.ToDictionary())
                    .ToDictionary(k => k.Key, v => v.Value);
            }
            else
            {
                queryParams = searchFilter.ToDictionary();
            }

            return await _requester.GetAndDeserializeAsync<ItemsList<Clan>>(ClansUrl, queryParams);
        }


        /// <inheritdoc />
        public async Task<CurrentWar> GetCurrentClanWarAsync(string clanTag)
            => await _requester.GetAndDeserializeAsync<CurrentWar>(ClansUrl + HttpUtility.UrlEncode(clanTag) + "/currentwar");


        /// <inheritdoc />
        public async Task<Clan> GetClanAsync(string clanTag)
            => await _requester.GetAndDeserializeAsync<Clan>(ClansUrl + HttpUtility.UrlEncode(clanTag));


        /// <inheritdoc />
        public async Task<ItemsList<Member>> GetClanMembersAsync(string clanTag, PagingFilter pagingFilter = null)
            => await _requester.GetAndDeserializeAsync<ItemsList<Member>>(ClansUrl + HttpUtility.UrlEncode(clanTag) + "/members",
                pagingFilter?.ToDictionary());
    }
}