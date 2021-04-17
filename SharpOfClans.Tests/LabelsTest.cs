using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace SharpOfClans.Tests
{
    public class LabelsTest : TestBase
    {
        [Fact]
        public async Task GetPlayerLabels()
        {
            var playerLabels = await ClashApi.Labels.GetPlayerLabelsAsync();

            playerLabels.Items.Count
                .Should()
                .Be(18, "it's the number of player labels returned by the API.");

            playerLabels.Items.First().Id.Should().Be(57000000, "it's the first Id returned by the API.");
        }


        [Fact]
        public async Task GetClanLabels()
        {
            var clanLabels = await ClashApi.Labels.GetClanLabelsAsync();
            
            clanLabels.Items.Count
                .Should()
                .Be(16, "it's the number of clan labels returned by the API.");

            clanLabels.Items.First().Id.Should().Be(56000000, "it's the first Id returned by the API.");
        }
    }
}
