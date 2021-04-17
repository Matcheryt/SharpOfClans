using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace SharpOfClans.Tests
{
    public class PlayerTest : TestBase
    {
        [Fact]
        public async Task SearchedPlayer_HasSameTagAsReturnedPlayer()
        {
            var player = await ClashApi.Players.GetPlayerAsync(MyProfileTag);

            player.Tag.Should().Be(MyProfileTag);
            player.Clan.Tag.Should().Be(Clan1Tag);
        }

        [Fact]
        public async Task PlayerToken_IsValidIfTokenPassed_InvalidIfNoTokenPassed()
        {
            var verify = await ClashApi.Players.VerifyPlayerTokenAsync("#L22YL908", PlayerToken);

            if (string.IsNullOrEmpty(PlayerToken))
            {
                verify.Status.Should().Be("invalid", "an invalid player token was passed to the API.");
                return;
            }

            verify.Status.Should().Be("ok", "a valid player token was passed to the API.");
        }
    }
}
