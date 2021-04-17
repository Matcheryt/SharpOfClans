using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace SharpOfClans.Tests
{
    public class GoldpassTest : TestBase
    {
        [Fact]
        public async Task GetGolpassSeason()
        {
            var season = await ClashApi.Goldpass.GetCurrentGoldpassSeasonAsync();

            var seasonStartTime = new DateTime(2021, 04, 01, 08, 01, 00);
            var seasonEndTime = new DateTime(2021, 05, 01, 08, 00, 00);

            season.StartTime.Should().Be(seasonStartTime, "it's the expected season start time.");
            season.EndTime.Should().Be(seasonEndTime, "it's the expected season end time.");
        }
    }
}
