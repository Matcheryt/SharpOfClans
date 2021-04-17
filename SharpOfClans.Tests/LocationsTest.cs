using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace SharpOfClans.Tests
{
    public class LocationsTest : TestBase
    {
        [Fact]
        public async Task LocationRankings_FirstItemReturned_IsTheOneWithHighestRanking()
        {
            var clanRankings = await ClashApi.Locations.GetLocationClanRankingsAsync(32000017);
            var playerRankings = await ClashApi.Locations.GetLocationPlayerRankingsAsync(32000017);
            var clanVsRankings = await ClashApi.Locations.GetLocationClansVersusRankingsAsync(32000017);
            var playerVsRankings = await ClashApi.Locations.GetLocationPlayersVersusRankingsAsync(32000017);

            clanRankings.Items.First().Rank
                .Should()
                .Be(1, "the first clan in the list should be the one with rank 1.");

            playerRankings.Items.First().Rank
                .Should()
                .Be(1, "the first player in the list should be the one with rank 1.");

            clanVsRankings.Items.First().Rank
                .Should()
                .Be(1, "the first clan in the list should be the one with rank 1.");

            playerVsRankings.Items.First().Rank
                .Should()
                .Be(1, "the first player in the list should be the one with rank 1.");
        }

        [Fact]
        public async Task LocationsList_ReturnsEuropeAsFirstItem_HasCorrectCountOfLocations()
        {
            var locations = await  ClashApi.Locations.GetLocationsListAsync();

            locations.Items.First().Name.Should().Be("Europe", "it's the first item on the list");
            locations.Items.Count.Should().Be(266, "it's the number of locations returned by the API");
        }

        [Fact]
        public async Task LocationSearched_IsTheOneReturned()
        {
            const int id = 32000188;
            var location = await ClashApi.Locations.GetLocationInfoAsync(id);
            Assert.Equal(id, location.Id);
        }
    }
}
