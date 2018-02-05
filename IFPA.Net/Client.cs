using System;
using System.Threading.Tasks;

using Flurl;
using Flurl.Http;

using IFPA.Net.Model.Calendar;
using IFPA.Net.Model.Player;
using IFPA.Net.Model.PlayerVsPlayer;
using IFPA.Net.Model.Rankings;
using IFPA.Net.Model.Stats;
using IFPA.Net.Model.Tournament;

namespace IFPA.Net
{
	public class Client : IClient
	{
		private readonly string API_KEY = "";

		private readonly string BASE_URI = "https://api.ifpapinball.com/v1";

		// ReSharper disable once InconsistentNaming
		public Client(string API_KEY)
		{
			if (string.IsNullOrEmpty(API_KEY)) throw new ArgumentException("API_KEY cannot be null");
			this.API_KEY = API_KEY;
		}

		public async Task<RankingsResponse> GetRankings(
			int startPos = 1,
			int count = 50,
			RankingsSortOrder order = RankingsSortOrder.Points)
		{
			return await Exec<RankingsResponse>(
				       "/rankings".SetQueryParam("start_pos", startPos).SetQueryParam("count", count)
					       .SetQueryParam("order", order.ToString().ToLower()));
		}

		#region Player vs Player

		public async Task<PlayerVsPlayerResponse> GetPlayerVsPlayerResponse(int p1, int p2)
		{
			return await Exec<PlayerVsPlayerResponse>($"/pvp".SetQueryParam("p1", p1).SetQueryParam("p2", p2));
		}

		#endregion

		private async Task<T> Exec<T>(string endpoint)
		{
			endpoint = BASE_URI + endpoint;
			var t = endpoint.SetQueryParam("api_key", API_KEY);
			return await t.GetJsonAsync<T>();
		}

		private object Cb(string s)
		{
			throw new NotImplementedException();
		}

		#region calendar

		public async Task<CalendarActiveResponse> GetCalendarActive(string country = null)
		{
			return await Exec<CalendarActiveResponse>($"/calendar/active".SetQueryParam("country", country));
		}

		public async Task<CalendarHistoryResponse> GetCalendarHistory(string country)
		{
			return await Exec<CalendarHistoryResponse>($"/calendar/history".SetQueryParam("country", country));
		}

		public async Task<CalendarResponse> GetCalendar(int calendarId)
		{
			return await Exec<CalendarResponse>($"/calendar/{calendarId}");
		}

		public async Task<CalendarSearchResponse> SearchCalendar(
			string address = null,
			int? withinmiles = null,
			int? withinKilometers = null)
		{
			return await Exec<CalendarSearchResponse>(
				       $"/calendar/search".SetQueryParam("address", address).SetQueryParam("m", withinmiles)
					       .SetQueryParam("k", withinKilometers));
		}

		#endregion

		#region player

		public async Task<PlayerResponse> GetPlayer(int playerId)
		{
			return await Exec<PlayerResponse>($"/player/{playerId}");
		}

		public async Task<PlayerResultsResponse> GetPlayerResults(int playerId)
		{
			return await Exec<PlayerResultsResponse>($"/player/{playerId}/results");
		}

		public async Task<PlayerPvpResponse> GetPlayerPVP(int playerId)
		{
			return await Exec<PlayerPvpResponse>($"/player/{playerId}/pvp");
		}

		public async Task<PlayerSearchResponse> SearchPlayer(string query, string email = null)
		{
			return await Exec<PlayerSearchResponse>($"/player/search".SetQueryParam("q", query).SetQueryParam("email", email));
		}

		public async Task<PlayerCountryDirectorsResponse> GetCountryDirectors()
		{
			return await Exec<PlayerCountryDirectorsResponse>($"/player/country_directors");
		}

		public async Task<PlayerHistoryResponse> GetPlayerHistory(int playerId)
		{
			return await Exec<PlayerHistoryResponse>($"/player/{playerId}/history");
		}

		#endregion

		#region tournament

		public async Task<TournamentResponse> GetTournament(int tournamentId)
		{
			return await Exec<TournamentResponse>($"/tournament/{tournamentId}");
		}

		public async Task<TournamentResultsResponse> GetTournamentResults(
			int tournamentId,
			int? eventId = null,
			string tourDate = null)
		{
			return await Exec<TournamentResultsResponse>(
				       $"/tournament/{tournamentId}/results".SetQueryParam("event_id", eventId != null ? eventId : null)
					       .SetQueryParam("tour_date", tourDate));
		}

		public async Task<TournamentListResponse> GetTournamentList(int startPos = 1, int count = 100)
		{
			return await Exec<TournamentListResponse>(
				       $"/tournament/list".SetQueryParam("start_pos", startPos).SetQueryParam("count", count));
		}

		public async Task<TournamentSearchResponse> SearchTournament(string query)
		{
			return await Exec<TournamentSearchResponse>($"/tournament/search".SetQueryParam("q", query));
		}

		#endregion

		#region stats

		public async Task<StatsPointsThisYearResponse> GetStatsPointsThisYear()
		{
			return await Exec<StatsPointsThisYearResponse>($"/stats/points_this_year");
		}

		public async Task<StatsMostEventsResponse> GetStatsMostEvents()
		{
			return await Exec<StatsMostEventsResponse>($"/stats/most_events");
		}

		public async Task<StatsCountryPlayersResponse> GetStatsCountryPlayers()
		{
			return await Exec<StatsCountryPlayersResponse>($"/stats/country_players");
		}

		public async Task<StatsEventsByYearResponse> GetStatsEventsByYear()
		{
			return await Exec<StatsEventsByYearResponse>($"/stats/events_by_year");
		}

		public async Task<StatsPlayersByYearResponse> GetStatsPlayersByYear()
		{
			return await Exec<StatsPlayersByYearResponse>($"/stats/players_by_year");
		}

		public async Task<StatsBiggestMoversResponse> GetStatsBiggestMovers()
		{
			return await Exec<StatsBiggestMoversResponse>($"/stats/biggest_movers");
		}

		#endregion
	}
}