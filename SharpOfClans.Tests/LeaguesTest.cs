using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using SharpOfClans.Models.Leagues.Enums;
using SharpOfClans.Paging;

namespace SharpOfClans.Tests
{
    public class LeaguesTest : TestBase
    {
        [Fact]
        public async Task LeaguesList_ReturnsCorrectCountOfLeagues()
        {
            var leagues = await ClashApi.Leagues.GetLeaguesAsync();

            leagues.Items.Count
                .Should()
                .Be(23, "it's the number of league Ids returned by the API.");
        }

        [Fact]
        public async Task LeagueSeasonRanking_FirstPlayerReturned_IsTheOneWithHighestRanking()
        {
            var seasonRankings = await ClashApi.Leagues.GetLeagueSeasonRankingsAsync(Leagues.Legend, "2021-02", new PagingFilter()
            {
                Limit = 2
            });

            seasonRankings.Items.First().Rank
                .Should()
                .Be(1, "the first player in the list should be the one with rank 1.");
        }

        [Fact]
        public async Task LeagueSearched_IsTheOneReturned()
        {
            var league = await ClashApi.Leagues.GetLeagueInfoAsync(Leagues.Bronze1);

            league.Id.Should().Be((int) Leagues.Bronze1, "it's the league we searched for.");
        }

        [Fact]
        public async Task FirstLegendLeagueSeason_IsTheCorrectOne()
        {
            var leagueSeason = await ClashApi.Leagues.GetLeagueSeasonsAsync(Leagues.Legend);

            leagueSeason.Items.First().Id.Should().Be("2015-07", "it's the first season for the league");
        }


        [Fact]
        public async Task WarLeagueSearched_IsTheCorrectOne()
        {
            var warLeague = await ClashApi.Leagues.GetWarLeagueAsync(WarLeagues.Bronze1);

            warLeague.Id.Should().Be((int) WarLeagues.Bronze1, "it's the war league we searched for.");
        }

        [Fact]
        public async Task WarLeaguesList_HasCorrectCountOfLeagues()
        {
            var warLeagues = await ClashApi.Leagues.GetWarLeaguesAsync();

            warLeagues.Items.Count.Should().Be(19, "it's the number of leagues returned by the API");
        }


    }
}
