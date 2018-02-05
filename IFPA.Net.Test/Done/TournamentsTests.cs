using System.Threading.Tasks;

using Xunit;

// ReSharper disable InconsistentNaming

namespace IFPA.Net.Test
{
	[Collection("Test collection")]
	public class TournamentsTests
	{
		public TournamentsTests(IfpaTestFixture fixture)
		{
			this.fixture = fixture;
		}

		private readonly IfpaTestFixture fixture;

		[Fact]
		public async Task Tournament_details()
		{
			var res = await fixture.client.GetTournament(fixture.TournamentId);
			Assert.Equal("Straight Down the Holidays", res.Tournament.TournamentName);
		}

		[Fact]
		public async Task Tournament_List()
		{
			var res = await fixture.client.GetTournamentList(1, 10);
			Assert.Equal(10, res.Tournament.Count);
		}

		[Fact]
		public async Task Tournament_results()
		{
			var res = await fixture.client.GetTournamentResults(fixture.TournamentId);
			Assert.True(res.Tournament.Results.Count > 40);
		}

		[Fact]
		public async Task Tournament_results_tour_Date()
		{
			var res = await fixture.client.GetTournamentResults(fixture.TournamentId, null, "2017-12-28");
			Assert.Equal("Straight Down the Holidays", res.Tournament.TournamentName);
		}

		[Fact]
		public async Task Tournament_Search()
		{
			var res = await fixture.client.SearchTournament("Straight Down");
			Assert.Equal(1, res.SearchResult.Count);
		}
	}
}