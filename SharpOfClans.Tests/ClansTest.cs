using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using SharpOfClans.Models.Clans.Enums;
using SharpOfClans.Paging;
using Xunit;

namespace SharpOfClans.Tests
{
    public class ClansTest : TestBase
    {
        //[Fact]
        //public async Task GetClanLeagueGroup()
        //{
        //    var clanLeagueGroup = ClashApi.Clans.GetCurrentCwlGroupAsync(Clan1Tag).Result;
        //    Assert.True(clanLeagueGroup.Clans.Any(x => x.Tag == Clan1Tag));
        //}

        //[Fact]
        //public async Task GetCwlWar()
        //{
        //    var cwlWar = ClashApi.Clans.GetCwlWarAsync(Clan1Tag).Result;
        //    cwlWar.ClanOne.Should().Be(Clan1Tag);
        //}

        [Fact]
        public async Task ClanWarLog_HasSameTagAsClanSearched()
        {
            var warLog = await ClashApi.Clans.GetClanWarLogAsync(Clan1Tag);

            warLog.Items.Select(pastWar => pastWar.Clan.Tag)
                .Should()
                .OnlyContain(x => x.Equals(Clan1Tag), "we searched for the war log of the clan with the clanTag");
        }

        [Fact]
        public async Task SearchedClans_MatchFilters()
        {
            var clanSearch = await ClashApi.Clans.SearchClansAsync(SearchFilter,
                new PagingFilter
                {
                    Limit = 20
                });

            var clans = clanSearch.Items;

            clans.Count
                .Should()
                .BeLessOrEqualTo(20, "we used a paging filter with a limit of 20 results.");

            clans.Select(clan => clan.Name)
                .Should()
                .OnlyContain(x => x.Contains("300"), "we searched for clans with the name '300'.");

            clans.Select(clan => clan.WarFrequency)
                .Should()
                .AllBeEquivalentTo(WarFrequency.Always, "we searched for clans with a WarFrequency of Always.");

            clans.Select(clan => clan.Location.Id)
                .Should()
                .AllBeEquivalentTo(32000188, "we searched for clans with this specific location id.");
        }

        [Theory]
        [InlineData(Clan1Tag)]
        [InlineData(Clan2Tag)]
        public async Task GetClan_HaveSameTag(string clanTag)
        {
            var clan = await ClashApi.Clans.GetClanAsync(clanTag);

            clan.Tag.Should()
                .Be(clanTag, "we searched for a clan with a specific tag, so the returned clan must have the same tag.");
        }

        [Fact]
        public async Task CurrentClanWar_HasSearchedClanTag_IfWarStateInWar()
        {
            var currentWar = await ClashApi.Clans.GetCurrentClanWarAsync(Clan1Tag);

            if (currentWar.State != WarState.NotInWar)
            {
                currentWar.FriendlyClan.Tag
                    .Should()
                    .Be(Clan1Tag, "we searched for the current war of a clan with a specific tag, so the clan returned must have the same tag.");
            }

        }

        [Fact]
        public async Task GetClanMembers()
        {
            var membersList = await ClashApi.Clans.GetClanMembersAsync(Clan1Tag);
            membersList.Items.Select(member => member.Tag)
                .Should()
                .Contain(MyProfileTag, "the clan we searched for has a member with the MyProfileTag tag.");
        }
    }
}
