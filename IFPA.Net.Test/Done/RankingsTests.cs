using System.Threading.Tasks;

using Xunit;

// ReSharper disable InconsistentNaming

namespace IFPA.Net.Test
{
	[Collection("Test collection")]
	public class RankingsTests
	{
		public RankingsTests(IfpaTestFixture fixture)
		{
			this.fixture = fixture;
		}

		private readonly IfpaTestFixture fixture;

		[Fact]
		public async Task Rankings_should_return_10()
		{
			var res = await fixture.client.GetRankings(count: 10);
			Assert.Equal(10, res.Rankings.Count);
		}
	}
}