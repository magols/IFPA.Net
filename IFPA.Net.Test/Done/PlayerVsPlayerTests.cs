using System.Threading.Tasks;

using Xunit;

namespace IFPA.Net.Test
{
	[Collection("Test collection")]
	public class PlayerVsPlayerTests
	{
		public PlayerVsPlayerTests(IfpaTestFixture fixture)
		{
			this.fixture = fixture;
		}

		private readonly IfpaTestFixture fixture;

		[Fact]
		public async Task Player_versus_player()
		{
			var res = await fixture.client.GetPlayerVsPlayerResponse(fixture.PlayerId, 11);

			Assert.Equal("Magnus", res.P1FirstName);
		}
	}
}