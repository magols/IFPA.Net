using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Stats
{
	public class StatsEventByYear
	{
		[JsonProperty("year")]
		public string Year { get; set; }

		[JsonProperty("country_count")]
		public string CountryCount { get; set; }

		[JsonProperty("periodic_count")]
		public string PeriodicCount { get; set; }

		[JsonProperty("count")]
		public string Count { get; set; }

		[JsonProperty("stats_rank")]
		public int StatsRank { get; set; }
	}

	public class StatsEventsByYearResponse
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("stats")]
		public IList<StatsEventByYear> Stats { get; set; }
	}
}