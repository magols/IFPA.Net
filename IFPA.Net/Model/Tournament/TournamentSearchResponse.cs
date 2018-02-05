using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Tournament
{
	public class TournamentSearchResult
	{
		[JsonProperty("tournament_id")]
		public string TournamentId { get; set; }

		[JsonProperty("tournament_name")]
		public string TournamentName { get; set; }

		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("event_count")]
		public string EventCount { get; set; }

		[JsonProperty("event_type")]
		public string EventType { get; set; }

		[JsonProperty("last_event_date")]
		public string LastEventDate { get; set; }
	}

	public class TournamentSearchResponse
	{
		[JsonProperty("search")]
		public string Search { get; set; }

		[JsonProperty("tournament")]
		public IList<TournamentSearchResult> SearchResult { get; set; }
	}
}