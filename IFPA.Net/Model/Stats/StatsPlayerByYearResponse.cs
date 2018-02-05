using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Stats
{
	public class StatsPlayersByYear
	{
		[JsonProperty("year")]
		public string Year { get; set; }

		[JsonProperty("count")]
		public string Count { get; set; }

		[JsonProperty("previous_year_count")]
		public string PreviousYearCount { get; set; }

		[JsonProperty("previous_2_year_count")]
		public string Previous2YearCount { get; set; }

		[JsonProperty("stats_rank")]
		public int StatsRank { get; set; }
	}

	public class StatsPlayersByYearResponse
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("stats")]
		public IList<StatsPlayersByYear> Stats { get; set; }
	}
}