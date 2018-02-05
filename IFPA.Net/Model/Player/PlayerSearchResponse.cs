using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Player
{
	public class PlayerSearchResult
	{
		[JsonProperty("player_id")]
		public string PlayerId { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("wppr_rank")]
		public string WpprRank { get; set; }
	}

	public class PlayerSearchResponse
	{
		[JsonProperty("query")]
		public string Query { get; set; }

		[JsonProperty("search")]
		public IList<PlayerSearchResult> SearchResult { get; set; }
	}
}