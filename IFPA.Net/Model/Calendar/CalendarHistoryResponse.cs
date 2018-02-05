using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Calendar
{
	public class CalendarHistory
	{
		[JsonProperty("calendar_id")]
		public string CalendarId { get; set; }

		[JsonProperty("tournament_id")]
		public string TournamentId { get; set; }

		[JsonProperty("tournament_name")]
		public string TournamentName { get; set; }

		[JsonProperty("event_name")]
		public string EventName { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("start_date")]
		public string StartDate { get; set; }

		[JsonProperty("end_date")]
		public string EndDate { get; set; }

		[JsonProperty("winner_name")]
		public string WinnerName { get; set; }

		[JsonProperty("winner_player_key")]
		public string WinnerPlayerKey { get; set; }

		[JsonProperty("player_count")]
		public string PlayerCount { get; set; }

		[JsonProperty("results_status")]
		public string ResultsStatus { get; set; }
	}

	public class CalendarHistoryResponse
	{
		[JsonProperty("calendar")]
		public IList<CalendarHistory> History { get; set; }

		[JsonProperty("total_entries")]
		public int TotalEntries { get; set; }

		[JsonProperty("available_months")]
		public IList<AvailableMonth> AvailableMonths { get; set; }

		[JsonProperty("available_countries")]
		public IList<AvailableCountry> AvailableCountries { get; set; }
	}
}