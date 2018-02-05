using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Stats
{
	public class StatsCountryPlayers
	{
		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		[JsonProperty("count")]
		public string Count { get; set; }

		[JsonProperty("stats_rank")]
		public int StatsRank { get; set; }
	}

	public class StatsCountryPlayersResponse
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("stats")]
		public IList<StatsCountryPlayers> Stats { get; set; }
	}
}