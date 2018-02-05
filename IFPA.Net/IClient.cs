using System.Threading.Tasks;

using IFPA.Net.Model.Calendar;
using IFPA.Net.Model.Player;
using IFPA.Net.Model.PlayerVsPlayer;
using IFPA.Net.Model.Rankings;
using IFPA.Net.Model.Stats;
using IFPA.Net.Model.Tournament;

namespace IFPA.Net
{
	public enum RankingsSortOrder
	{
		Points,

		Rating,

		Eff_Pct
	}

	public interface IClient
	{
		#region Rankings 

		Task<RankingsResponse> GetRankings(
			int startPos = 1,
			int count = 50,
			RankingsSortOrder order = RankingsSortOrder.Points);

		#endregion

		#region Payer vs Player

		Task<PlayerVsPlayerResponse> GetPlayerVsPlayerResponse(int p1, int p2);

		#endregion

		#region Calendar

		Task<CalendarActiveResponse> GetCalendarActive(string country = null);

		Task<CalendarHistoryResponse> GetCalendarHistory(string country);

		Task<CalendarResponse> GetCalendar(int calendarId);

		Task<CalendarSearchResponse> SearchCalendar(
			string address = null,
			int? withinmiles = null,
			int? withinKilometers = null);

		#endregion

		#region Player

		Task<PlayerResponse> GetPlayer(int playerId);

		Task<PlayerResultsResponse> GetPlayerResults(int playerId);

		Task<PlayerPvpResponse> GetPlayerPVP(int playerId);

		Task<PlayerSearchResponse> SearchPlayer(string query, string email = null);

		Task<PlayerCountryDirectorsResponse> GetCountryDirectors();

		Task<PlayerHistoryResponse> GetPlayerHistory(int playerId);

		#endregion

		#region Tournaments 

		Task<TournamentResponse> GetTournament(int tournamentId);

		Task<TournamentResultsResponse> GetTournamentResults(int tournamentId, int? eventId, string tourDate = null);

		// tourdate format = "2014-01-01"
		Task<TournamentListResponse> GetTournamentList(int startPos = 1, int count = 100);

		Task<TournamentSearchResponse> SearchTournament(string query);

		#endregion

		#region Stats 

		Task<StatsPointsThisYearResponse> GetStatsPointsThisYear();

		Task<StatsMostEventsResponse> GetStatsMostEvents();

		Task<StatsCountryPlayersResponse> GetStatsCountryPlayers();

		Task<StatsEventsByYearResponse> GetStatsEventsByYear();

		Task<StatsPlayersByYearResponse> GetStatsPlayersByYear();

		Task<StatsBiggestMoversResponse> GetStatsBiggestMovers();

		#endregion
	}
}