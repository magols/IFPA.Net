using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Tournament
{
	public class TournamentListEntry
	{
		[JsonProperty("tournament_id")]
		public string TournamentId { get; set; }

		[JsonProperty("tournament_name")]
		public string TournamentName { get; set; }

		[JsonProperty("event_name")]
		public string EventName { get; set; }

		[JsonProperty("event_date")]
		public string EventDate { get; set; }

		[JsonProperty("winner_name")]
		public string WinnerName { get; set; }

		[JsonProperty("winner_player_id")]
		public string WinnerPlayerId { get; set; }

		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("player_count")]
		public string PlayerCount { get; set; }
	}

	public class TournamentListResponse
	{
		[JsonProperty("tournament")]
		public IList<TournamentListEntry> Tournament { get; set; }

		[JsonProperty("total_results")]
		public string TotalResults { get; set; }
	}
}