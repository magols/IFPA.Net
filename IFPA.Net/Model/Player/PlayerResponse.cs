using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Player
{
	public class Player
	{
		[JsonProperty("player_id")]
		public string PlayerId { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("initials")]
		public string Initials { get; set; }

		[JsonProperty("age")]
		public int Age { get; set; }

		[JsonProperty("excluded_flag")]
		public string ExcludedFlag { get; set; }

		[JsonProperty("ifpa_registered")]
		public string IfpaRegistered { get; set; }
	}

	public class PlayerStats
	{
		[JsonProperty("current_wppr_rank")]
		public string CurrentWpprRank { get; set; }

		[JsonProperty("last_month_rank")]
		public string LastMonthRank { get; set; }

		[JsonProperty("last_year_rank")]
		public string LastYearRank { get; set; }

		[JsonProperty("highest_rank")]
		public string HighestRank { get; set; }

		[JsonProperty("highest_rank_date")]
		public string HighestRankDate { get; set; }

		[JsonProperty("current_wppr_value")]
		public string CurrentWpprValue { get; set; }

		[JsonProperty("wppr_points_all_time")]
		public string WpprPointsAllTime { get; set; }

		[JsonProperty("best_finish")]
		public string BestFinish { get; set; }

		[JsonProperty("best_finish_count")]
		public string BestFinishCount { get; set; }

		[JsonProperty("average_finish")]
		public string AverageFinish { get; set; }

		[JsonProperty("average_finish_last_year")]
		public string AverageFinishLastYear { get; set; }

		[JsonProperty("total_events_all_time")]
		public string TotalEventsAllTime { get; set; }

		[JsonProperty("total_active_events")]
		public string TotalActiveEvents { get; set; }

		[JsonProperty("total_events_away")]
		public string TotalEventsAway { get; set; }

		[JsonProperty("ratings_rank")]
		public string RatingsRank { get; set; }

		[JsonProperty("ratings_value")]
		public string RatingsValue { get; set; }

		[JsonProperty("efficiency_rank")]
		public string EfficiencyRank { get; set; }

		[JsonProperty("efficiency_value")]
		public string EfficiencyValue { get; set; }
	}

	public class ChampionshipSery
	{
		[JsonProperty("view_id")]
		public string ViewId { get; set; }

		[JsonProperty("group_code")]
		public string GroupCode { get; set; }

		[JsonProperty("group_name")]
		public string GroupName { get; set; }

		[JsonProperty("rank")]
		public string Rank { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }
	}

	public class PlayerResponse
	{
		[JsonProperty("player")]
		public Player Player { get; set; }

		[JsonProperty("player_stats")]
		public PlayerStats PlayerStats { get; set; }

		[JsonProperty("championshipSeries")]
		public IList<ChampionshipSery> ChampionshipSeries { get; set; }
	}
}