using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Player
{
	public class Result
	{
		[JsonProperty("tournament_id")]
		public string TournamentId { get; set; }

		[JsonProperty("tournament_name")]
		public string TournamentName { get; set; }

		[JsonProperty("event_name")]
		public string EventName { get; set; }

		[JsonProperty("event_date")]
		public string EventDate { get; set; }

		[JsonProperty("position")]
		public string Position { get; set; }

		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		[JsonProperty("periodic_flag")]
		public string PeriodicFlag { get; set; }

		[JsonProperty("wppr_state")]
		public string WpprState { get; set; }

		[JsonProperty("original_points")]
		public string OriginalPoints { get; set; }

		[JsonProperty("current_points")]
		public string CurrentPoints { get; set; }
	}

	public class PlayerResultsResponse
	{
		[JsonProperty("player_id")]
		public int PlayerId { get; set; }

		[JsonProperty("results_count")]
		public int ResultsCount { get; set; }

		[JsonProperty("results")]
		public IList<Result> Results { get; set; }
	}
}