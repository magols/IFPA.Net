using System.Threading.Tasks;

using Xunit;

// ReSharper disable InconsistentNaming

namespace IFPA.Net.Test
{
	[Collection("Test collection")]
	public class StatsTests
	{
		public StatsTests(IfpaTestFixture fixture)
		{
			this.fixture = fixture;
		}

		private readonly IfpaTestFixture fixture;

		[Fact]
		public async Task biggest_movers()
		{
			var res = await fixture.client.GetStatsBiggestMovers();
			Assert.True(1 < res.Stats.Count);
		}

		[Fact]
		public async Task country_players()
		{
			var res = await fixture.client.GetStatsCountryPlayers();
			Assert.True(10 < res.Stats.Count);
		}

		[Fact]
		public async Task events_by_year()
		{
			var res = await fixture.client.GetStatsEventsByYear();
			Assert.True(1 < res.Stats.Count);
		}

		[Fact]
		public async Task most_events()
		{
			var res = await fixture.client.GetStatsMostEvents();
			Assert.True(1 < res.Stats.Count);
		}

		[Fact]
		public async Task players_by_year()
		{
			var res = await fixture.client.GetStatsPlayersByYear();
			Assert.True(1 < res.Stats.Count);
		}

		[Fact]
		public async Task points_this_year()
		{
			var res = await fixture.client.GetStatsPointsThisYear();
			Assert.True(10 < res.Stats.Count);
		}
	}
}