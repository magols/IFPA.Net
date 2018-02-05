using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Tournament
{
	public class Result2
	{
		[JsonProperty("position")]
		public string Position { get; set; }

		[JsonProperty("player_id")]
		public string PlayerId { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		[JsonProperty("wppr_rank")]
		public string WpprRank { get; set; }

		[JsonProperty("ratings_value")]
		public string RatingsValue { get; set; }

		[JsonProperty("points")]
		public string Points { get; set; }
	}

	public class Tournament2
	{
		[JsonProperty("tournament_name")]
		public string TournamentName { get; set; }

		[JsonProperty("tournament_id")]
		public string TournamentId { get; set; }

		[JsonProperty("event_name")]
		public object EventName { get; set; }

		[JsonProperty("event_date")]
		public string EventDate { get; set; }

		[JsonProperty("periodic_count")]
		public int PeriodicCount { get; set; }

		[JsonProperty("rating_strength")]
		public object RatingStrength { get; set; }

		[JsonProperty("ranking_strength")]
		public object RankingStrength { get; set; }

		[JsonProperty("base_value")]
		public string BaseValue { get; set; }

		[JsonProperty("event_value")]
		public string EventValue { get; set; }

		[JsonProperty("results")]
		public IList<Result2> Results { get; set; }
	}

	public class TournamentResultsResponse
	{
		[JsonProperty("tournament")]
		public Tournament2 Tournament { get; set; }
	}
}