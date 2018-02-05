using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Stats
{
	public class StatsMostEvents
	{
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

		[JsonProperty("count")]
		public string Count { get; set; }

		[JsonProperty("stats_rank")]
		public int StatsRank { get; set; }
	}

	public class StatsMostEventsResponse
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("stats")]
		public IList<StatsMostEvents> Stats { get; set; }
	}
}