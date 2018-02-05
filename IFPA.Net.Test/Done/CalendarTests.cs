using System.Linq;
using System.Threading.Tasks;

using Xunit;

// ReSharper disable InconsistentNaming

namespace IFPA.Net.Test
{
	[Collection("Test collection")]
	public class CalendarTests
	{
		public CalendarTests(IfpaTestFixture fixture)
		{
			this.fixture = fixture;
		}

		private readonly IfpaTestFixture fixture;

		[Fact]
		public async Task Calendar()
		{
			var res = await fixture.client.GetCalendar(fixture.CalendarId);
			Assert.Equal(fixture.TournamentId.ToString(), res.Calendar.First()?.TournamentId);
		}

		[Fact]
		public async Task Calendar_Search()
		{
			var res = await fixture.client.SearchCalendar("stockholm", withinKilometers: 150);
			Assert.True(2 < res.Results.Count);
		}

		[Fact]
		public async Task CalendarActive()
		{
			var res = await fixture.client.GetCalendarActive();
			Assert.True(10 < res.Active.Count);
		}

		[Fact]
		public async Task CalendarActive_Sweden()
		{
			var res = await fixture.client.GetCalendarActive("Sweden");
			Assert.True(10 < res.Active.Count);
		}

		[Fact]
		public async Task CalendarHistory_Sweden()
		{
			var res = await fixture.client.GetCalendarHistory("Sweden");
			Assert.True(1000 < res.History.Count);
		}
	}
}