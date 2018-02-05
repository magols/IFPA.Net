using System.Linq;
using System.Threading.Tasks;

using Xunit;

namespace IFPA.Net.Test
{
	[Collection("Test collection")]
	public class PlayerTests
	{
		public PlayerTests(IfpaTestFixture fixture)
		{
			this.fixture = fixture;
		}

		private readonly IfpaTestFixture fixture;

		[Fact]
		public async Task Player()
		{
			var res = await fixture.client.GetPlayer(fixture.PlayerId);
			Assert.Equal(fixture.PlayerId.ToString(), res.Player.PlayerId);
		}

		[Fact]
		public async Task Player_CountryDirectors()
		{
			var res = await fixture.client.GetCountryDirectors();
			Assert.True(res.Results.Count > 10);
		}

		[Fact]
		public async Task Player_History()
		{
			var res = await fixture.client.GetPlayerHistory(fixture.PlayerId);
			Assert.True(res.RankHistory.Count > 10);
		}

		[Fact]
		public async Task Player_pvp()
		{
			var res = await fixture.client.GetPlayerPVP(fixture.PlayerId);
			Assert.True(res.Pvp.Count > 10);
		}

		[Fact]
		public async Task Player_results()
		{
			var res = await fixture.client.GetPlayerResults(fixture.PlayerId);
			Assert.True(res.Results.Count > 10);
		}

		[Fact]
		public async Task Player_search()
		{
			var res = await fixture.client.SearchPlayer("magnus olsson");
			res.SearchResult.Single(s => s.PlayerId == fixture.PlayerId.ToString());
		}
	}
}